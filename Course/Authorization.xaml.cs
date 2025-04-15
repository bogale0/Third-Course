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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        static bool auth = true;
        public Authorization()
        {
            InitializeComponent();
        }

        private void SwitchRegAuth(object sender, RoutedEventArgs e)
        {
            auth = !auth;
            login.Text = "";
            password.Password = "";
            enterButton.IsEnabled = false;
            if (auth)
            {
                enterButton.Content = "Войти";
                switchButton.Content = "Регистрация";
            }
            else
            {
                enterButton.Content = "Зарегистрироваться";
                switchButton.Content = "Авторизация";
            }
        }

        private void ChangedLogOrPass(object sender, KeyEventArgs e)
        {
            if (login.Text != "" && password.Password != "")
            {
                enterButton.IsEnabled = true;
            }
            else
            {
                enterButton.IsEnabled = false;
            }
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            courseEntities db = new courseEntities();
            if (auth)
            {
                var user = db.User.FirstOrDefault(el => el.login == login.Text && el.password == password.Password);
                if (user == null)
                {
                    MessageBox.Show("Неправильный логин или пароль", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                Session.role = user.role;
                MessageBox.Show("Успешная авторизация", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                var user = db.User.FirstOrDefault(el => el.login == login.Text);
                if (user != null)
                {
                    MessageBox.Show("Существует пользователь с таким логином", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                db.User.Add(new User { login = login.Text, password = password.Password, role = 1 });
                db.SaveChanges();
                MessageBox.Show("Успешная регистрация", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
