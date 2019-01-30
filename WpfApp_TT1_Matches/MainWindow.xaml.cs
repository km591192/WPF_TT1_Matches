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

namespace WpfApp_TT1_Matches
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Matches matches = new Matches();

        private int N = 0;
        private string S = String.Empty;


        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            N = Convert.ToInt32(tbNumber.Text);
            matches.checkn(N);
            tbMsg.Text += matches.S + "\n";
            tbMsg.Text += matches.minmatches(N) + "\n";
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            tbNumber.Text = String.Empty;
            tbMsg.Text = String.Empty;
        }
    }
}
