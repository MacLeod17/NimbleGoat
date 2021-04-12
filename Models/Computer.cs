using System;
using System.Collections.Generic;
using System.Text;

namespace NimbleGoat.Models
{
    class Computer : Player
    {
        enum eMode
        {
            EASY,
            HARD
        }

        eMode mode = eMode.EASY;

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
