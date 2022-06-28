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

namespace regtr
{
    /// <summary>
    /// Логика взаимодействия для sell.xaml
    /// </summary>
    public partial class sell : Window
    {
        KURSA44Entities3 database = new KURSA44Entities3();
        items shmot = new items();


        public sell(items books)
        {
            InitializeComponent();
            manganame.Text = books.name;
            mangaprice.Text = books.cost.ToString();
            shmot = books;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            prodaja sell1 = new prodaja()
            {
                items_id = shmot.item_id,
                client_id = halfa.user.client_id,
               
            };
            database.prodaja.Add(sell1);
            database.SaveChanges();
            MessageBox.Show("Cпасибо за покупку");
            this.Close();


        }
    }


    public static class halfa
    {
        public static client user { get; set; }


    }
}
