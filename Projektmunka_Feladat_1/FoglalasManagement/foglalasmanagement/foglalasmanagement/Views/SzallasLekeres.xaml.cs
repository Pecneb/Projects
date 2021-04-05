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
using System.IO;

namespace foglalasmanagement.Views
{
    /// <summary>
    /// Interaction logic for SzallasLekeres.xaml
    /// </summary>
    public partial class SzallasLekeres : UserControl
    {
        private string Filename { get { return "ugyfelek.txt"; } }
        public List<Szemely> Ugyfelek { get {
                if (File.Exists(Filename))
                {
                    return new DataParser(Filename).ParseToSzemely();
                }
                else
                {
                    return new List<Szemely>();
                }
            }
        }
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
            Szemely tmp_szemely = new Szemely(tbx_vnev.Text, tbx_knev.Text);
            int exists = tmp_szemely.PersonIndexInList(Ugyfelek);
            if(exists != -1)
            {
                lv_FoglalasInfo.ItemsSource = Ugyfelek[exists].SzallasFoglalasok;
            } else
            {
                MessageBox.Show("A keresett ugyfelnek meg nincs foglalasa!");
            }
            // Meg implementalni kell hogy a ListView be bekeruljenek a foglalas adatai!
        }
    }
}
