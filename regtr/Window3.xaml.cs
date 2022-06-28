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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window

    {
        public Window3()
        {
            InitializeComponent();
    
        }
        private void Button_Click_Prosmotr(object sender, RoutedEventArgs e)
        {
            Window1 reg = new Window1();
            this.Close();
            reg.Show();
        }

        private void Button_Click_Items(object sender, RoutedEventArgs e)
        {
            dobavlenietovarov items = new dobavlenietovarov();
            this.Close();
            items.Show();   
        }
        private void Button_Click_Back5(object sender, RoutedEventArgs e)
        {
            MainWindow reg = new MainWindow();
            this.Close();
            reg.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            analizprodaj summa = new analizprodaj();
            this.Close();
            summa.Show();
        }
    }
}
