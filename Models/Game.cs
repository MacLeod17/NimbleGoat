﻿using System;
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
            return false;
        }
        #endregion

        public Player playerTurn;
        public Player[] players;
        public int[] board;
        
        public bool SwapTurn()
        {
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

            Pages.Game_Page.TxtPlayerTurn.Text = playerTurn.name;
            return true;
        }

        public bool EndTurn()
        {
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
