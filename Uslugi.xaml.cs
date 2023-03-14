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
    /// Логика взаимодействия для Uslugi.xaml
    /// </summary>
    public partial class Uslugi : Window
    {
        UPrEntities db;
        List<Услуги> tb;
        public Uslugi()
        {
            InitializeComponent();
            db = new UPrEntities();
            tb = db.Услуги.ToList();
            tableGrid.ItemsSource = tb;
        }
        private void refreshdatagrid()
        {
            tableGrid.ItemsSource = db.Услуги.ToList();
            tableGrid.Items.Refresh();
        }

        private void Add_button(object sender, RoutedEventArgs e)
        {
            var nw = new Услуги();
            db.Услуги.Add(nw);
            Add_Uslugi add = new Add_Uslugi(db, nw);
            add.ShowDialog();
            refreshdatagrid();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            db = new UPrEntities();
            Услуги item = tableGrid.SelectedItem as Услуги;
            Услуги del = db.Услуги.Where(d => d.id == item.id).Single();
            db.Услуги.Remove(del);
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
