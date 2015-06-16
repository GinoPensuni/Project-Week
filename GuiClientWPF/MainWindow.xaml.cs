﻿using System;
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
using GuiClientWPF.Assets.Windows;

namespace GuiClientWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ClientManager manager;
        private HelpWindowUI uihelper;
        private HelpWindowControl controlhelper;

        public MainWindow()
        {
            this.manager = new ClientManager();
            InitializeComponent();
        }

        private void ExitAction_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private async void DisconnectAction_Click(object sender, RoutedEventArgs e)
        {
            await manager.Disconnect();
        }

        private async void ConnectAction_Click(object sender, RoutedEventArgs e)
        {
            await manager.ConnectAction();
        }

        private async void SaveAction_Click(object sender, RoutedEventArgs e)
        {
            await manager.SaveComponent(this.Workstation);
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
            controlhelper = new HelpWindowControl();
            controlhelper.Visibility = Visibility.Visible;
        }

        private void HelpUI_Click(object sender, RoutedEventArgs e)
        {
            uihelper = new HelpWindowUI();
            uihelper.Visibility = Visibility.Visible;
        }
    }
}
