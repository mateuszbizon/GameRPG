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
