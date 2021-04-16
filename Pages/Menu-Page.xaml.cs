using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NimbleGoat.Models;

namespace NimbleGoat.Windows
{
    /// <summary>
    /// Interaction logic for Menu_Page.xaml
    /// </summary>
    public partial class Menu_Page : Page
    {
        public Menu_Page()
        {
            InitializeComponent();
        }

        private void btnPlayGame_Click(object sender, RoutedEventArgs e)
        {
            Game.Initialize();

            MainWindow.mainFrame.Navigate(new System.Uri("Pages/PlayerSelection-Page.xaml", UriKind.Relative));
        }

        private void btnInstructions_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new System.Uri("Pages/Instructions-Page.xaml", UriKind.Relative));
        }

        private void btnGOAT_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new System.Uri("Pages/GOAT - Page.xaml", UriKind.Relative));
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
