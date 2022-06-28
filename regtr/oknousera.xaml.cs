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
    /// Логика взаимодействия для oknousera.xaml
    /// </summary>
    public partial class oknousera : Window

    {
        KURSA44Entities3 database = new KURSA44Entities3();
        items item = new items();
        public oknousera()
        {
            InitializeComponent();
            var strmanga = database.items.Select(t => t).ToList();
            govno1.ItemsSource = strmanga;
        }

        private void Button_Click_Back9(object sender, RoutedEventArgs e)
        {
            
                MainWindow main = new MainWindow();
                this.Close();
                main.Show();
            
        }
        private void govno2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            item = (items)govno1.SelectedItem;
            sell sellmanga = new sell(item);
            sellmanga.ShowDialog();
        }

        private void govno1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    } 

}
