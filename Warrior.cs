using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class Warrior : Hero
    {
        public Warrior(int health = 150, int damage = 15) : base(health, damage) {
            this.health = health;
            this.damage = damage;
        }
    }
}
