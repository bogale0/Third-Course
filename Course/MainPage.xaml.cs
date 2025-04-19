using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Course
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            using (var db = new courseEntities())
            {
                var result = db.User.FirstOrDefault(x => x.id == Session.id);
                if (result == null)
                {
                    NavigationService.Navigate(new Authorization());
                    return;
                }
                Session.role = result.role;
                if (Session.role < 3)
                {
                    menuUser.Visibility = Visibility.Collapsed;
                    menuRooms.Visibility = Visibility.Collapsed;
                }
                if (Session.role < 2)
                {
                    saveButton.Visibility = Visibility.Collapsed;
                    table.IsReadOnly = true;
                }
            }
        }

        private void DateAndClassChosen(object sender, RoutedEventArgs e)
        {
            int @class = classChosen.SelectedIndex;
            if (!dateChosen.SelectedDate.HasValue || @class == -1)
            {
                return;
            }
            var date = (DateTime)dateChosen.SelectedDate;
            using (var db = new courseEntities())
            {
                var data = db.Schedule.Where(x => x.date == date && x.@class == @class);
                if (!data.Any())
                {
                    data = db.Schedule.Where(x => x.day == (int)date.DayOfWeek - 1 && x.@class == @class);
                }
                table.ItemsSource = data.ToList();
            }
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            int @class = classChosen.SelectedIndex;
            var date = (DateTime)dateChosen.SelectedDate;
            using (var db = new courseEntities())
            {
                var daySchedule = table.ItemsSource as IEnumerable<Schedule>;
                if (db.Schedule.Where(x => x.@class == @class && x.date == date).Any())
                {
                    foreach (var rowSchedule in daySchedule)
                    {
                        db.Entry(rowSchedule).State = EntityState.Modified;
                    }
                }
                else
                {
                    foreach (var row in daySchedule)
                    {
                        db.Schedule.Add(new Schedule { room = row.room, state = row.state, groupName = row.groupName, teacher = row.teacher, @class = row.@class, date = date });
                    }
                }
                db.SaveChanges();
            }
        }

        private void ExitAuth(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authorization());
        }

        private void OpenRoomsList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RoomsList());
        }

        private void OpenSchedule(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ScheduleEdit());
        }

        private void OpenUserList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UsersList());
        }
    }
}
