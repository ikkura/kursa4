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
    /// Логика взаимодействия для dobavlenieclientov.xaml
    /// </summary>
    public partial class dobavlenieclientov : Window
    {
        KURSA44Entities3 database = new KURSA44Entities3();
        client users = new client();
        public dobavlenieclientov()
        {
           
            InitializeComponent();
        }
        private void Button_Click_Dobavit(object sender, RoutedEventArgs e)
        {
            client agag = new client()
            {
                name = Name.Text,
                lastname = Lastname.Text,
                phone = Phone.Text,
                adress = Address.Text,
                //price = Cost.Text,
            };

            database.client.Add(agag);
            database.SaveChanges();
            this.Close();
        }

        private void Button_Click_Nazad(object sender, RoutedEventArgs e)
        {                    
                this.Close();                          
        }
    }
}
