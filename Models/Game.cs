using System;
using System.Collections.Generic;
using System.Text;

namespace NimbleGoat.Models
{
    public class Game
    {
        #region Singleton
        private static Game _instance;

        public Game Instance { get { return _instance; } }

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
            return true;
        }

        public bool EndTurn()
        {
            return true;
        }

        public bool Reset()
        {
            return true;
        }
    }
}
