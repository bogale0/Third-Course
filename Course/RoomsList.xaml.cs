using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
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
    /// Логика взаимодействия для RoomsList.xaml
    /// </summary>
    public partial class RoomsList : Page
    {
        public RoomsList()
        {
            InitializeComponent();
            using (var db = new courseEntities())
            {
                RoomsListView.ItemsSource = db.Rooms.ToList();
            }
        }

        private void AddRoom(object sender, RoutedEventArgs e)
        {
            int room = Convert.ToInt32(newRoom.Text);
            using (var db = new courseEntities())
            {
                if (db.Rooms.FirstOrDefault(x => x.number == room) != null)
                {
                    MessageBox.Show("Комната уже существует", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                db.Rooms.Add(new Rooms { number = room });
                for (byte i = 0, j = 0; j != 6;)
                {
                    db.Schedule.Add(new Schedule { room = room, state = "Свободно", @class = i, day = j });
                    if (++i == 5)
                    {
                        i = 0;
                        j++;
                    }
                }
                db.SaveChanges();
                RoomsListView.ItemsSource = db.Rooms.ToList();
            }
        }

        private void DeleteRoom(object sender, RoutedEventArgs e)
        {
            int room = Convert.ToInt32(newRoom.Text);
            using (var db = new courseEntities())
            {
                Rooms Room = db.Rooms.FirstOrDefault(x => x.number == room);
                if (Room == null)
                {
                    MessageBox.Show("Комнаты не существует", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                db.Rooms.Remove(Room);
                db.SaveChanges();
                RoomsListView.ItemsSource = db.Rooms.ToList();
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
