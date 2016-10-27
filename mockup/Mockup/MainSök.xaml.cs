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

namespace Mockup {
    /// <summary>
    /// Interaction logic for Sök.xaml
    /// </summary>
    public partial class MainSök : Window {
        public MainSök() {
            InitializeComponent();
        }

        private void Sök_Clicked(object sender, RoutedEventArgs e) {
            Sök sök = new Sök();
            sök.ShowDialog();
        }
    }
}
