using GameRPG;
using GameRPG.Services;

class Program
{
    static void Main(string[] args)
    {
        DependencyInjection di = new DependencyInjection();

        di.ChooseHero();
        
        try
        {
            while(true)
            {
                di.Fight();
            }
        } catch(WinnerWasCalled ex)
        {
            Console.WriteLine("Koniec gry");
        }
    }
}