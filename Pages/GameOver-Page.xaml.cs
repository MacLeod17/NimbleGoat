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

namespace NimbleGoat.Pages
{
    /// <summary>
    /// Interaction logic for GameOver_Page.xaml
    /// </summary>
    public partial class GameOver_Page : Page
    {
        public GameOver_Page()
        {
            InitializeComponent();
        }

        private void btnPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new System.Uri("Pages/PlayerSelection-Page.xaml", UriKind.Relative));
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new System.Uri("Pages/Menu-Page.xaml", UriKind.Relative));
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
