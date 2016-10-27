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

namespace Mockup {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Admin_Clicked(object sender, RoutedEventArgs e) {
            MainAdmin mainAdmin = new MainAdmin();
            mainAdmin.ShowDialog();
        }

        private void Resultat_Clicked(object sender, RoutedEventArgs e) {
            MainResultat mainResultat = new MainResultat();
            mainResultat.ShowDialog();
        }

        private void Sök_Clicked(object sender, RoutedEventArgs e) {
            MainSök mainSök = new MainSök();
            mainSök.ShowDialog();
        }
    }
}
