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
using System.Windows.Shapes;

namespace Учебка
{
    /// <summary>
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        UPrEntities db;
        List<Клиенты> tb;
        public Clients()
        {
            InitializeComponent();
            db = new UPrEntities();
            tb = db.Клиенты.ToList();
            tableGrid.ItemsSource = tb;
        }
        private void refreshdatagrid()
        {
            tableGrid.ItemsSource = db.Клиенты.ToList();
            tableGrid.Items.Refresh();
        }

        private void Add_button(object sender, RoutedEventArgs e)
        {
            var nw = new Клиенты();
            db.Клиенты.Add(nw);
            Add_Clients add = new Add_Clients(db, nw);
            add.ShowDialog();
            refreshdatagrid();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            db = new UPrEntities();
            Клиенты item = tableGrid.SelectedItem as Клиенты;
            Клиенты del = db.Клиенты.Where(d => d.id == item.id).Single();
            db.Клиенты.Remove(del);
            db.SaveChanges();
            MessageBox.Show("Строка успешно удалена!");
            refreshdatagrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            refreshdatagrid();
        }
    }
}

