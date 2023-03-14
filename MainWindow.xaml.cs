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

namespace Учебка
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Password;

            // здесь должна быть проверка введенных данных на соответствие
            // например, сравнение с данными из базы данных или файла конфигурации

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Вы успешно авторизовались!");
                Navigation navigation = new Navigation();
                navigation.ShowDialog();
            }
            if (username == "timur" && password == "sobolev")
            {
                MessageBox.Show("Здравствуйте, " + username + "!");
                Navigation navigation = new Navigation();
                navigation.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль. Попробуйте еще раз.");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
