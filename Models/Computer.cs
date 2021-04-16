using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;
using NimbleGoat.Pages;

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
                rowNum = rand.Next(0, Game.Instance.board.Length - 1);
                numVal = Game.Instance.board[rowNum];
            }

            numItemsToTake = rand.Next(1, Game.Instance.board[rowNum]);

            int num = Game.Instance.board[rowNum] - numItemsToTake;
            Game_Page.rows[rowNum].Source = new BitmapImage(new Uri(@"\Assets\Images\Blades_" + ((num == -1) ? Game.Instance.board[0] : num) + ".png", UriKind.Relative));
            EndTurn();
        }

        private void HardTurn()
        {
            int nimSum = NimSum(Game.Instance.board);
            int[] board = Game.Instance.board;
            //Computer is winning
            if(nimSum != 0)
            {
                for (int i = 0; i < board.Length; i++)
                {
                    if((board[i] ^ nimSum) < board[i])
                    {
                        rowNum = i;
                        numItemsToTake = board[i] - (board[i] ^ nimSum);
                    }
                }

                int num = Game.Instance.board[rowNum] - numItemsToTake;
                Hard_Game_Page.rows[rowNum].Source = new BitmapImage(new Uri(@"\Assets\Images\Blades_" + ((num == -1) ? Game.Instance.board[0] : num) + ".png", UriKind.Relative));
                EndTurn();
            }
            //Computer is loosing
            else
            {
                EasyTurn();
            }
        }

        public int NimSum(int[] board)
        {
            int nimSum = board[0];
            for (int i = 1; i < board.Length; i++)
            {
                nimSum ^= board[i];
            }

            return nimSum;
        }

        public override bool EndTurn()
        {
            Game.Instance.board[rowNum] -= numItemsToTake;
            
            Game.Instance.EndTurn();

            return true;
        }
    }
}
