using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для UsersList.xaml
    /// </summary>
    public partial class UsersList : Page
    {
        public UsersList()
        {
            InitializeComponent();
            using (var db = new courseEntities())
            {
                table.ItemsSource = db.User.Include(x => x.Roles).ToList();
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void TableDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var user = (User)table.SelectedItem;
            if (user.login == "admin")
            {
                MessageBox.Show("Невозможно изменить привелегии этого пользователя", "Отказано в доступе", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (++user.role == 4)
            {
                user.role = 1;
            }
            using (var db = new courseEntities())
            {
                user.Roles = db.Roles.FirstOrDefault(x => x.id == user.role);
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
            }
            table.Items.Refresh();
        }

        private void RemoveUser(object sender, RoutedEventArgs e)
        {
            var user = (User)table.SelectedItem;
            if (user.login == "admin")
            {
                MessageBox.Show("Невозможно удалить этого пользователя", "Отказано в доступе", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            using (var db = new courseEntities())
            {
                db.Entry(user).State = EntityState.Deleted;
                db.SaveChanges();
                table.ItemsSource = db.User.Include(x => x.Roles).ToList();
            }
        }
    }
}
