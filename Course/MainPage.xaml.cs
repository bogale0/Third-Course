using System;
using System.Collections.Generic;
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

        private void ExitAuth(object sender, RoutedEventArgs e)
        {
            Session.role = 0;
            NavigationService.Navigate(new Authorization());
        }

        private void OpenRoomsList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RoomsList());
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {

        }

        private void DayAndClassChosen(object sender, RoutedEventArgs e)
        {

        }

        private void OpenSchedule(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ScheduleEdit());
        }
    }
}
