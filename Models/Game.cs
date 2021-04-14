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

        public Game()
        {
            _instance = this;
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
                    return true;
                }
                else
                {
                    playerTurn = players[0];
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool EndTurn()
        {
            SwapTurn();
            return true;
        }

        public bool Reset()
        {
            return true;
        }
    }
}
