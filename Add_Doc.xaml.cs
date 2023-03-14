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
    /// Логика взаимодействия для Add_Doc.xaml
    /// </summary>
    public partial class Add_Doc : Window
    {
        UPrEntities db;
        public Add_Doc(UPrEntities db, Документы d)
        {
            InitializeComponent();
            this.db = db;
            this.DataContext = d;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Строка успешно добавлена!");
            db.SaveChanges();
            this.Close();
        }
    }
}
