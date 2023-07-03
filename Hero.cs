using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class Hero
    {
        protected int health;
        protected int damage;

        public Hero(int health, int damage)
        {
            this.health = health;
            this.damage = damage;
        }
    }
}
