namespace GameRPG
{
    class Warrior : Hero
    {
        public Random rand = new Random();

        public Warrior(int health = 150, int damage = 15, int maxHealth = 150) : base(health, damage, maxHealth)
        {
            this.health = health;
            this.damage = damage;
            this.maxHealth = maxHealth;
        }

        public override int Attack()
        {
            int randomAttack = rand.Next(this.damage) + 1;

            return randomAttack;
        }

        public override void SetHealth(int health)
        {
            this.health = health;
        }

        public override int GetHealth()
        {
            return health;
        }

        public override void SetHealthToMax()
        {
            health = maxHealth;
        }
    }
}
