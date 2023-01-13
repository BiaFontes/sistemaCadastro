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
using Teste1.TesteTela;

namespace Teste1
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

        private void BtnUm_Click(object sender, RoutedEventArgs e)
        {
            Window W1 = new Tela1();
            W1.Show();
        }

        private void BtnDois_Click(object sender, RoutedEventArgs e)
        {
            Window W2 = new Tela2();
            W2.Show();
        }

        private void BtnTres_Click(object sender, RoutedEventArgs e)
        {
            Window W3 = new Tela3();
            W3.Show();
        }

        private void BtnQuatro_Click(object sender, RoutedEventArgs e)
        {
            Window W4 = new Tela4();
            W4.Show();
        }
    }
}
