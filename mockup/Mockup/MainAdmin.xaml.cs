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
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class MainAdmin : Window {
        public MainAdmin() {
            InitializeComponent();
        }

        private void Login_Clicked(object sender, RoutedEventArgs e) {
            Admin admin = new Admin();
            admin.ShowDialog();
        }
    }
}
