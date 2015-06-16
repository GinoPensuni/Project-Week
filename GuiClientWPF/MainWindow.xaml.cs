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

namespace GuiClientWPF
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

        private void ExitAction_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void DisconnectAction_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ConnectAction_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveAction_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RunAction_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ConnectionOptions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PreferencesOptions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HelpControls_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HelpUI_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
