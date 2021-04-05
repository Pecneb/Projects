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
using foglalasmanagement.Views;
using foglalasmanagement.DataStruct;
using System.IO;

namespace foglalasmanagement.Views
{
    /// <summary>
    /// Interaction logic for SzallasFelvetel.xaml
    /// </summary>
    public partial class SzallasFelvetel : Window
    {
        // DataParser classunk egesz jol muzsikal!!
        public string Filename { get { return "ugyfelek.txt"; } }
        public List<Szemely> Ugyfelek { get; set; }
        public SzallasFelvetel()
        {
            InitializeComponent();
            if (File.Exists(Filename))
            {
                Ugyfelek = new DataParser(Filename).ParseToSzemely();
            }
            else
            {
                Ugyfelek = new List<Szemely>();
            }
        }
        public static string DatumToString(DateTime? datum)
        {
            string datum_string = "";
            for (int j = 0; j < datum.ToString().Split(' ').Length; j++)
            {
                datum_string += datum.ToString().Split(' ')[j];
            }
            return datum_string;
        }
        private void btn_mentes_Click(object sender, RoutedEventArgs e)
        {
            string vnev = tbx_vnev.Text;
            string knev = tbx_knev.Text;
            string azon = tbx_azon.Text;
            string tol = DatumToString(dp_kezdet.SelectedDate);
            string ig = DatumToString(dp_veg.SelectedDate);
            Szemely tmp_szemely = new Szemely(tbx_vnev.Text, tbx_knev.Text);
            int tmp_index = 0;
            if (tmp_szemely.PersonIndexInList(Ugyfelek, tmp_index) == -1)
            {
                Ugyfelek.Add(new Szemely(tbx_vnev.Text, tbx_knev.Text));
                Ugyfelek[tmp_index].SzallasFoglalasok.Add(new SzallasFoglalas(vnev, knev, azon, tol, ig));
            }
            else
            {
                Ugyfelek[tmp_szemely.PersonIndexInList(Ugyfelek, tmp_index)].SzallasFoglalasok.Add(new SzallasFoglalas(vnev, knev, azon, tol, ig));
            }
            DataParser dp = new DataParser("ugyfelek.txt");
            dp.SzemelyToText(Ugyfelek);
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Azonosito keszitese egesz jol mukodik de meg lehet rajta alakitani!
            string vnev = tbx_vnev.Text;
            string knev = tbx_knev.Text;
            string tol = DatumToString(dp_kezdet.SelectedDate);
            string ig = DatumToString(dp_veg.SelectedDate);
            tbx_azon.Text = vnev[0] + knev[0] + tol + ig + Ugyfelek.Count;
        }
    }
}
