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
        int numItemsToTake;
        int rowNum;

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
            rowNum = -1;

            while (numVal == 0)
            {
                rowNum = rand.Next(0, Game.Instance.board.Length);
                numVal = Game.Instance.board[rowNum];
            }

            numItemsToTake = rand.Next(1, Game.Instance.board[numVal]);

            EndTurn();
        }

        private void HardTurn()
        {

        }

        public override bool EndTurn()
        {
            Game.Instance.board[rowNum] = numItemsToTake;

            Game.Instance.EndTurn();

            return true;
        }
    }
}
