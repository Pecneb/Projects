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
        public List<Szemely> Ugyfelek { 
            get {
                if(File.Exists(Filename))
                {
                    return new DataParser(Filename).ParseToSzemely();
                } else
                {
                    return new List<Szemely>();
                }
            } 
        }
        public SzallasFelvetel()
        {
            InitializeComponent();
        }
        
        //Ezt a szarost kell befejezni minel elobb!!!!
        private void btn_mentes_Click(object sender, RoutedEventArgs e)
        {
            string vnev = tbx_vnev.Text;
            string knev = tbx_knev.Text;
            string azon = tbx_azon.Text;
            string tol = dp_kezdet.SelectedDate.ToString();
            string ig = dp_veg.SelectedDate.ToString();
            int i = 0;
            while(i<Ugyfelek.Count && (Ugyfelek[i].VezetekNev != vnev && Ugyfelek[i].KeresztNev != knev))
            {
                i++;
            }
            if(i == Ugyfelek.Count)
            {
                // Valamiert index out of range exeptiont dob ki, ki kellene vizsgalni minel elobb!!!
                Ugyfelek.Add(new Szemely(tbx_vnev.Text, tbx_knev.Text));
                Ugyfelek[i].SzallasFoglalasok.Add(new SzallasFoglalas(vnev, knev, azon, tol, ig));
            } else
            {
                Ugyfelek[i].SzallasFoglalasok.Add(new SzallasFoglalas(vnev, knev, azon, tol, ig));
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
            string tol = dp_kezdet.SelectedDate.ToString();
            string ig = dp_veg.SelectedDate.ToString();
            tbx_azon.Text = vnev[0] + knev[0] + tol + ig + Ugyfelek.Count;
        }
    }
}
