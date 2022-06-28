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
    /// Логика взаимодействия для analizprodaj.xaml
    /// </summary>
    
    public partial class analizprodaj : Window

        
    {
        KURSA44Entities3 database = new KURSA44Entities3();
        public analizprodaj()
        {
            InitializeComponent();
        var query = database.prodaja.Select(t=>t.summa).Sum();
            summa.Text = query.ToString();

        }

        private void Button_Click_Back10(object sender, RoutedEventArgs e)
        {
            
                Window3 back = new Window3();
                this.Close();
                back.Show();
            
        }
    }
}

