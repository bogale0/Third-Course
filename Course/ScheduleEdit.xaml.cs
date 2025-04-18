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
    /// Логика взаимодействия для ScheduleEdit.xaml
    /// </summary>
    public partial class ScheduleEdit : Page
    {
        public ScheduleEdit()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            byte day = Convert.ToByte(dayChosen.SelectedIndex),
                @class = Convert.ToByte(classChosen.SelectedIndex);
            using (var db = new courseEntities())
            {
                var daySchedule = table.ItemsSource as IEnumerable<Schedule>;
                foreach (var rowSchedule in daySchedule)
                {
                    db.Entry(rowSchedule).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
        }

        private void DayAndClassChosen(object sender, RoutedEventArgs e)
        {
            if (dayChosen.SelectedIndex == -1 || classChosen.SelectedIndex == -1)
            {
                return;
            }
            byte day = Convert.ToByte(dayChosen.SelectedIndex),
                @class = Convert.ToByte(classChosen.SelectedIndex);
            using (var db = new courseEntities())
            {
                table.ItemsSource = db.Schedule.Where(x => x.day == day && x.@class == @class).ToList();
            }
        }
    }
}
