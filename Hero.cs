namespace GameRPG
{
    abstract class Hero
    {
        protected int health;
        protected int maxHealth;
        protected int damage;

        public Hero(int health, int damage, int maxHealth)
        {
            this.health = health;
            this.damage = damage;
            this.maxHealth = maxHealth;
        }

        public abstract int Attack();
        public abstract void SetHealth(int health);
        public abstract int GetHealth();
        public abstract void SetHealthToMax();
    }
}
