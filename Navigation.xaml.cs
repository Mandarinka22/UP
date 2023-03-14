using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
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
using System.Windows.Shapes;

namespace Учебка
{
    /// <summary>
    /// Логика взаимодействия для Navigation.xaml
    /// </summary>
    public partial class Navigation : Window
    {
        public Navigation()
        {
            InitializeComponent();
        }


        private void Zakazy_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.ShowDialog();
        }

        private void Uslugi_Click(object sender, RoutedEventArgs e)
        {
            Uslugi u = new Uslugi();
            u.ShowDialog();
        }

        private void Documenty_Click(object sender, RoutedEventArgs e)
        {
            Doc d = new Doc();
            d.ShowDialog();
        }

        private void Clienty_Click(object sender, RoutedEventArgs e)
        {
            Clients c = new Clients();
            c.ShowDialog();
        }
    }
}