using System;
using System.Collections.Generic;
using System.Text;

namespace NimbleGoat.Models
{
    public abstract class Player
    {
        public string name { get; set; }
        public string imageName { get; set; }

        public abstract bool EndTurn();
        public abstract bool Turn();
    }
}
