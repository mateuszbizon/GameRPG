using GameRPG;

class Program
{
    static void Main(string[] args)
    {
       Game game = new Game();

        Mage mage = new Mage();
        Console.WriteLine(mage.attack());
    }
}