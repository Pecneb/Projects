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
using System.Windows.Navigation;
using System.Windows.Shapes;
using foglalasmanagement.DataStruct;

namespace foglalasmanagement.Views
{
    /// <summary>
    /// Interaction logic for SzallasLekeres.xaml
    /// </summary>
    public partial class SzallasLekeres : UserControl
    {
        public SzallasLekeres()
        {
            InitializeComponent();
        }

        private void btn_hozzaad_Click(object sender, RoutedEventArgs e)
        {
            SzallasFelvetel szf = new SzallasFelvetel();
            szf.Show();
        }

        private void btn_keres_Click(object sender, RoutedEventArgs e)
        {
            string vnev = tbx_vnev.Text;
            string knev = tbx_knev.Text;
            
        }
    }
}
