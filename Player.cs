using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class Player
    {
        public string name;
        public Hero chosenHero;

        public Player(string name, Hero chosenHero)
        {
            this.name = name;
            this.chosenHero = chosenHero;
        }
    }
}
