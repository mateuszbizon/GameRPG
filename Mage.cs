using GameRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class Mage : Hero
    {
        public Random rand = new Random();
        public Mage(int health = 100, int damage = 30) : base(health, damage) {
            this.health = health;
            this.damage = damage;
        }

        public override int Attack()
        {
            int randomAttack = rand.Next(this.damage) + 1;

            return randomAttack;
        }
    }
}
