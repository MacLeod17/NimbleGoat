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
    /// Interaction logic for PlayerSelection_Page.xaml
    /// </summary>
    public partial class PlayerSelection_Page : Page
    {
        public enum eGameType
        {
            Easy,
            Hard
        }

        public Computer.eMode comMode;
        public eGameType gameMode = eGameType.Easy;

        public PlayerSelection_Page()
        {
            InitializeComponent();
        }

        private void EasyPVPbtn_Click(object sender, RoutedEventArgs e)
        {
            //gameMode = eGameType.Easy;
        }

        private void HardPVPbtn_Click(object sender, RoutedEventArgs e)
        {
            //gameMode = eGameType.Hard;
        }

        private void EasyPVCbtn_Click(object sender, RoutedEventArgs e)
        {
            comMode = Computer.eMode.EASY;
            //gameMode = eGameType.Easy;
        }

        private void HardPVCbtn_Click(object sender, RoutedEventArgs e)
        {
            comMode = Computer.eMode.HARD;
            //gameMode = eGameType.Hard;
        }

        private void PVPPlaybtn_Click(object sender, RoutedEventArgs e)
        {
            Player p1 = new Human() { name = p1NameTxt.Text };
            Player p2 = new Human() { name = p2NameTxt.Text };

            Game.Instance.players[0] = p1;
            Game.Instance.players[1] = p2;

            Game.Instance.playerTurn = Game.Instance.players[0];

            if (gameMode == eGameType.Easy)
            {
                MainWindow.mainFrame.Navigate(new System.Uri("Pages/Game-Page.xaml", UriKind.Relative));
            }
            else
            {
                //MainWindow.mainFrame.Navigate(new System.Uri("Pages/Game2-Page.xaml", UriKind.Relative));
            }
        }

        private void PVCPlaybtn_Click(object sender, RoutedEventArgs e)
        {
            Player p1 = new Human() { name = p1NameTxt.Text };
            Player p2 = new Computer(Computer.eMode.EASY) { name = "Vincent Van Goat" };

            Game.Instance.players[0] = p1;
            Game.Instance.players[1] = p2;

            Game.Instance.playerTurn = Game.Instance.players[0];

            if (gameMode == eGameType.Easy)
            {
                MainWindow.mainFrame.Navigate(new System.Uri("Pages/Game-Page.xaml", UriKind.Relative));
            }
            else
            {
                //MainWindow.mainFrame.Navigate(new System.Uri("Pages/Game2-Page.xaml", UriKind.Relative));
            }
        }
    }
}
