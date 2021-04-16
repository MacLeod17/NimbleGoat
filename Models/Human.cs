using System;
using System.Collections.Generic;
using System.Text;

namespace NimbleGoat.Models
{
    public class Human : Player
    {
        public override bool EndTurn()
        {
            return true;
        }

        public override bool Turn()
        {
            return true;
        }
    }
}
