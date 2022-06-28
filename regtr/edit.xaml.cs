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
    /// Логика взаимодействия для edit.xaml
    /// </summary>
    public partial class edit : Window
    {
        KURSA44Entities3 database = new KURSA44Entities3();
        client client1;
        
        public edit(client client2)
        {
            InitializeComponent();
            zalupa.Text = client2.name;
            family.Text = client2.lastname;
            chlen.Text = client2.phone;
            asdasd.Text = client2.adress;
            client1 = client2;
            
        }

        private void Button_Click_Back4(object sender, RoutedEventArgs e)
        {
            Window1 back = new Window1();
            this.Close();
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            client1.name = zalupa.Text;
            var Surname = database.client.Where(t => t.client_id == client1.client_id).Select(t => t).FirstOrDefault();
            Surname.name = zalupa.Text;

            client1.name = family.Text;
            var name2 = database.client.Where(t => t.client_id == client1.client_id).Select(t => t).FirstOrDefault();
            name2.name = family.Text;

            client1.name = chlen.Text;
            var name3 = database.client.Where(t => t.client_id == client1.client_id).Select(t => t).FirstOrDefault();
            name3.name = chlen.Text;

            client1.name = asdasd.Text;
            var name4 = database.client.Where(t => t.client_id == client1.client_id).Select(t => t).FirstOrDefault();
            name4.name = asdasd.Text;

            database.SaveChanges();
            var query = Owner as Window1;
            query.hehehe(); 
            this.Close();
        }
    }
}
