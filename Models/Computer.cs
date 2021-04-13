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
            int numVals = 0;

            while (numVals == 0)
            {
                //numVals = Game
            }
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
