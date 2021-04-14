using System;
using System.Collections.Generic;
using System.Text;

namespace NimbleGoat.Models
{
    public class Computer : Player
    {
        public enum eMode
        {
            EASY,
            HARD
        }

        eMode mode = eMode.EASY;
        Random rand;

        public Computer(eMode m)
        {
            mode = m;
            rand = new Random();
        }

        public override bool Turn()
        {
            switch (mode)
            {
                case eMode.EASY:
                    EasyTurn();
                    break;
                case eMode.HARD:
                    HardTurn();
                    break;
                default:
                    return false;
            }

            return true;
        }

        private void EasyTurn()
        {
            int numVal = 0;
            int rowNum = -1;

            while (numVal == 0)
            {
                rowNum = rand.Next(0, Game.Instance.board.Length);
                numVal = Game.Instance.board[rowNum];
            }

            int numItemsToTake = rand.Next(1, Game.Instance.board[numVal]);

            //Interact with board using this information
        }

        private void HardTurn()
        {

        }

        public override bool EndTurn()
        {
            return true;
        }
    }
}
