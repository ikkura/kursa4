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
    /// Логика взаимодействия для dobavlenietovarov.xaml
    /// </summary>
    public partial class dobavlenietovarov : Window
    {
        KURSA44Entities3 database = new KURSA44Entities3();
        client users = new client();
        public dobavlenietovarov()
        {
            InitializeComponent();
            var strmanga = database.items.Select(t => t).ToList();
            govno.ItemsSource = strmanga;
        }
        private void Button_Click_Back3(object sender, RoutedEventArgs e)
        {
            Window3 back = new Window3();
            this.Close();
            back.Show();
        }
        private void Button_Click_delete1(object sender, RoutedEventArgs e)
        {
            var item = database.client.Where(a => a.user_id == users.client_id).FirstOrDefault();
            database.client.Remove(item);
            database.SaveChanges();
        }

    }
    
    }

