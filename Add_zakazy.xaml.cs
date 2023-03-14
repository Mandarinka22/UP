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
    /// Логика взаимодействия для Add_zakazy.xaml
    /// </summary>
    public partial class Add_zakazy : Window
    {
        UPrEntities db;
        public Add_zakazy(UPrEntities db, Заказы w1)
        {
            InitializeComponent();
            this.db = db;
            this.DataContext = w1;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Строка успешно добавлена");
            db.SaveChanges();
            this.Close();
        }
    }
}
