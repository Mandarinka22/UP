using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        UPrEntities db;
        List<Заказы> tb;
        public Window1()
        {
            InitializeComponent();
            db = new UPrEntities();
            tb = db.Заказы.ToList();
            tableGrid.ItemsSource = tb;
        }
        private void refreshdatagrid()
        {
            tableGrid.ItemsSource = db.Заказы.ToList();
            tableGrid.Items.Refresh();
        }

        private void Add_button(object sender, RoutedEventArgs e)
        {
            var nw = new Заказы();
            db.Заказы.Add(nw);
            Add_zakazy add = new Add_zakazy(db, nw);
            add.ShowDialog();
            refreshdatagrid();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            db = new UPrEntities();
            Заказы item = tableGrid.SelectedItem as Заказы;
            Заказы del = db.Заказы.Where(d => d.id == item.id).Single();
            db.Заказы.Remove(del);
            db.SaveChanges();
            MessageBox.Show("Строка успешно удалена!");
            refreshdatagrid();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Search = db.Заказы.ToList();
            Search = Search.Where(x => x.Клиенты.Фамилия.ToLower().StartsWith(Search_Box.Text.ToLower())).ToList();
            tableGrid.ItemsSource = Search.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           refreshdatagrid();
        }
    }
}
