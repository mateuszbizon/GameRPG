using GameRPG;

class Program
{
    static void Main(string[] args)
    {
       Game game = new Game();
        game.ChooseHero();
        
        try
        {
            while(true)
            {
                game.Fight();
            }
        } catch(WinnerWasCalled ex)
        {
            Console.WriteLine("Koniec gry");
        }
    }
}