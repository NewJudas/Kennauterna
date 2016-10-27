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
    /// Interaction logic for admin_prompt.xaml
    /// </summary>
    public partial class AdminPrompt : Window {
        public AdminPrompt() {
            InitializeComponent();
        }

        private void Sök_Clicked(object sender, RoutedEventArgs e) {
            Sök sök = new Sök();
            sök.ShowDialog();
        }

        private void Skapa_Clicked(object sender, RoutedEventArgs e) {
            Skapa skapa = new Skapa();
            skapa.ShowDialog();
        }
    }
}
