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

namespace NimbleGoat.Pages
{
    /// <summary>
    /// Interaction logic for Game_Page.xaml
    /// </summary>
    public partial class Game_Page : Page
    {
        int[] board;
        int currentVal = -1;

        public Game_Page()
        {
            InitializeComponent();
            board = new int[]{ 1, 3, 5};
        }

        private void btnRowOne_Click(object sender, RoutedEventArgs e)
        {
            if(currentVal == -1)
                currentVal = board[0] - 1;
            else
            {
                if(currentVal == 0)
                {
                    currentVal = board[0];
                    btnRowTwo.IsEnabled = true;
                    btnRowThree.IsEnabled = true;
                }
                else
                {
                    currentVal--;
                }
            }

            imgOne.Source = new BitmapImage(new Uri(@"\Assets\Images\Blades_" + currentVal + ".png", UriKind.Relative));
            btnRowTwo.IsEnabled = false;
            btnRowThree.IsEnabled = false;
        }

        private void btnRowTwo_Click(object sender, RoutedEventArgs e)
        {
            if (currentVal == -1)
                currentVal = board[1] - 1;
            else
            {
                if (currentVal == 0)
                {
                    currentVal = board[1];
                    btnRowOne.IsEnabled = true;
                    btnRowThree.IsEnabled = true;
                }
                else
                {
                    currentVal--;
                }
            }

            imgTwo.Source = new BitmapImage(new Uri(@"\Assets\Images\Blades_" + currentVal + ".png", UriKind.Relative));
            btnRowOne.IsEnabled = false;
            btnRowThree.IsEnabled = false;
        }

        private void btnRowThree_Click(object sender, RoutedEventArgs e)
        {
            if (currentVal == -1)
                currentVal = board[2] - 1;
            else
            {
                if (currentVal == 0)
                {
                    currentVal = board[2];
                    btnRowOne.IsEnabled = true;
                    btnRowTwo.IsEnabled = true;
                }
                else
                {
                    currentVal--;
                }
            }

            imgThree.Source = new BitmapImage(new Uri(@"\Assets\Images\Blades_" + currentVal + ".png", UriKind.Relative));
            btnRowOne.IsEnabled = false;
            btnRowTwo.IsEnabled = false;
        }

        private void btnEndTurn_Click(object sender, RoutedEventArgs e)
        {
            currentVal = -1;
        }
    }
}
