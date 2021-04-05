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
using foglalasmanagement.ViewModel;

namespace foglalasmanagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SzallasLekeres();
            btn_Szallasfoglalasmanagement.Background = Brushes.White;
            btn_Konerenciafoglalasmanagement.Background = Brushes.RoyalBlue;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataContext = new KonferenciaLekeres();
            btn_Szallasfoglalasmanagement.Background = Brushes.RoyalBlue;
            btn_Konerenciafoglalasmanagement.Background = Brushes.White;
        }
    }
}
