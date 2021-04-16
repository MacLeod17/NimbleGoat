using System;
using System.Collections.Generic;
using System.Text;

namespace NimbleGoat.Models
{
    public class Game
    {
        #region Singleton
        private static Game _instance;

        public static Game Instance { get { return _instance; } }

        private Game()
        {
            players = new Player[2];
        }

        public static bool Initialize()
        {
            if (_instance == null)
            {
                _instance = new Game();
                return true;
            }
            else
            {
                return Instance.Reset();
            }
        }
        #endregion

        public Player playerTurn;
        public Player[] players;
        public int[] board;
        
        public bool SwapTurn()
        {
            int total = 0;
            for (int i = 0; i < board.Length; i++)
            {
                total += board[i];
            }

            if(total == 0)
            {
                //Game over
                MainWindow.mainFrame.Navigate(new System.Uri("Pages/GameOver-Page.xaml", UriKind.Relative));
                return true;
            }

            try
            {
                if (playerTurn == players[0])
                {
                    playerTurn = players[1];
                }
                else
                {
                    playerTurn = players[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            if (Windows.PlayerSelection_Page.gameMode == Windows.PlayerSelection_Page.eGameType.Easy)
                Pages.Game_Page.TxtPlayerTurn.Text = playerTurn.name;
            else
                Pages.Hard_Game_Page.TxtPlayerTurn.Text = playerTurn.name;


            playerTurn.Turn();
            return true;
        }

        public bool EndTurn()
        {
            if(Windows.PlayerSelection_Page.gameMode == Windows.PlayerSelection_Page.eGameType.Easy)
            {
                Pages.Game_Page.board = board;
                foreach (var butt in Pages.Game_Page.buttons)
                {
                    butt.IsEnabled = true;
                }
            }
            else
            {
                foreach (var butt in Pages.Hard_Game_Page.buttons)
                {
                    butt.IsEnabled = true;
                }
            }
            
            SwapTurn();
            return true;
        }

        public bool Reset()
        {
            players[0] = null;
            players[1] = null;

            players = new Player[2];

            return true;
        }
    }
}
