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
    public partial class Hard_Game_Page : Page
    {
        int[] board;
        int currentVal = -1;
        int currentRow = -1;

        public static TextBlock TxtPlayerTurn;

        public Hard_Game_Page()
        {
            InitializeComponent();
            TxtPlayerTurn = txtPlayerTurn;
            board = new int[]{ 1, 3, 5, 7};
        }

        private void btnRowOne_Click(object sender, RoutedEventArgs e)
        {
            btnRowTwo.IsEnabled = false;
            btnRowThree.IsEnabled = false;
            btnRowFour.IsEnabled = false;
            btnEndTurn.IsEnabled = true;

            currentRow = 0;

            if (currentVal == -1)
                currentVal = board[0] - 1;
            else
            {
                if(currentVal == 0)
                {
                    currentVal = board[0];
                    btnRowTwo.IsEnabled = true;
                    btnRowThree.IsEnabled = true;
                    btnRowFour.IsEnabled = true;
                    btnEndTurn.IsEnabled = false;

                    currentVal = -1;
                    currentRow = -1;
                }
                else
                {
                    currentVal--;
                }
            }

            imgOne.Source = new BitmapImage(new Uri(@"\Assets\Images\Blades_" + ((currentVal == -1) ? board[0] : currentVal) + ".png", UriKind.Relative));
        }

        private void btnRowTwo_Click(object sender, RoutedEventArgs e)
        {
            btnRowOne.IsEnabled = false;
            btnRowThree.IsEnabled = false;
            btnRowFour.IsEnabled = false;
            btnEndTurn.IsEnabled = true;

            currentRow = 1;

            if (currentVal == -1)
                currentVal = board[1] - 1;
            else
            {
                if (currentVal == 0)
                {
                    currentVal = board[1];
                    btnRowOne.IsEnabled = true;
                    btnRowThree.IsEnabled = true;
                    btnRowFour.IsEnabled = true;
                    btnEndTurn.IsEnabled = false;

                    currentVal = -1;
                    currentRow = -1;
                }
                else
                {
                    currentVal--;
                }
            }

            imgTwo.Source = new BitmapImage(new Uri(@"\Assets\Images\Blades_" + ((currentVal == -1) ? board[1] : currentVal) + ".png", UriKind.Relative));
        }

        private void btnRowThree_Click(object sender, RoutedEventArgs e)
        {
            btnRowOne.IsEnabled = false;
            btnRowTwo.IsEnabled = false;
            btnRowFour.IsEnabled = false;
            btnEndTurn.IsEnabled = true;

            currentRow = 2;

            if (currentVal == -1)
                currentVal = board[2] - 1;
            else
            {
                if (currentVal == 0)
                {
                    currentVal = board[2];
                    btnRowOne.IsEnabled = true;
                    btnRowTwo.IsEnabled = true;
                    btnRowFour.IsEnabled = true;
                    btnEndTurn.IsEnabled = false;

                    currentVal = -1;
                    currentRow = -1;
                }
                else
                {
                    currentVal--;
                }
            }

            imgThree.Source = new BitmapImage(new Uri(@"\Assets\Images\Blades_" + ((currentVal == -1) ? board[2] : currentVal) + ".png", UriKind.Relative));
        }

        private void btnRowFour_Click(object sender, RoutedEventArgs e)
        {
            btnRowOne.IsEnabled = false;
            btnRowTwo.IsEnabled = false;
            btnRowThree.IsEnabled = false;
            btnEndTurn.IsEnabled = true;

            currentRow = 3;

            if (currentVal == -1)
                currentVal = board[3] - 1;
            else
            {
                if (currentVal == 0)
                {
                    currentVal = board[3];
                    btnRowOne.IsEnabled = true;
                    btnRowTwo.IsEnabled = true;
                    btnRowFour.IsEnabled = true;
                    btnEndTurn.IsEnabled = false;

                    currentVal = -1;
                    currentRow = -1;
                }
                else
                {
                    currentVal--;
                }
            }

            imgFour.Source = new BitmapImage(new Uri(@"\Assets\Images\Blades_" + ((currentVal == -1) ? board[3] : currentVal) + ".png", UriKind.Relative));
        }

        private void btnEndTurn_Click(object sender, RoutedEventArgs e)
        {
            if(currentRow == -1)
            {
                return;
            }

            Game.Instance.board[currentRow] = currentVal;
            board = Game.Instance.board;

            Game.Instance.EndTurn();

            //txtPlayerTurn.Text = Game.Instance.playerTurn.name;

            currentVal = -1;
        }
    }
}
