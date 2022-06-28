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
using System.Data.SqlClient;

namespace regtr
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        KURSA44Entities3 database = new KURSA44Entities3();
        client users = new client();
        public Window1()
        { 
            InitializeComponent();
            hehehe();
        }
        private void Button_Click_Back2(object sender, RoutedEventArgs e)
        {
            Window3 back = new Window3();
            this.Close();
            back.Show(); 
        }
        private void user_SelectedChanged(object sender,SelectionChangedEventArgs e)
        {
            users = govno.SelectedItem as client;
            edit panele = new edit(govno.SelectedItem as client);
            panele.Owner = this;    
            panele.ShowDialog();


        }
        private void Button_Click_delete(object sender, RoutedEventArgs e)
        {
            var author = database.client.Where(a => a.client_id == users.client_id).FirstOrDefault();
            database.client.Remove(author);
            database.SaveChanges();
        }
        public void hehehe()
        {
            var strmanga = database.client.Select(t => t).ToList();
            govno.ItemsSource = strmanga;
        }

        private void Button_Click_dobavit(object sender, RoutedEventArgs e)
        {
            dobavlenieclientov dob = new dobavlenieclientov();
            dob.Show();
        }

        void Button_Click_obnovit(object sender, RoutedEventArgs e)
        {
            Window1 refresh = new Window1();
            
            this.Close();
            refresh.Show();
        }
    }
      
}
