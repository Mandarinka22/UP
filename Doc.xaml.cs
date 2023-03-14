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
    /// Логика взаимодействия для Doc.xaml
    /// </summary>
    public partial class Doc : Window
    {
        UPrEntities db;
        List<Документы> tb;
        public Doc()
        {
            InitializeComponent();
            db = new UPrEntities();
            tb = db.Документы.ToList();
            tableGrid.ItemsSource = tb;
        }
        private void refreshdatagrid()
        {
            tableGrid.ItemsSource = db.Документы.ToList();
            tableGrid.Items.Refresh();
        }

        private void Add_button(object sender, RoutedEventArgs e)
        {
            var nw = new Документы();
            db.Документы.Add(nw);
            Add_Doc add = new Add_Doc(db, nw);
            add.ShowDialog();
            refreshdatagrid();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            db = new UPrEntities();
            Документы item = tableGrid.SelectedItem as Документы;
            Документы del = db.Документы.Where(d => d.id == item.id).Single();
            db.Документы.Remove(del);
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
