using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class Game
    {
        public List<Player> heroes;
        private readonly int amountOfPlayers = 2;
        private string inputPlayerName = "";
        private string inputPlayerHero = "";
        private bool isHeroChosen = false;

        public Game() { 
            heroes = new List<Player>();
        }

        public void ChooseHero()
        {
            for (int i = 0; i < amountOfPlayers; i++)
            {
                do
                {
                    Console.WriteLine($"Podaj imię gracza nr {i + 1} :");

                    inputPlayerName = Console.ReadLine();
                } while (inputPlayerName == "");

                isHeroChosen = false;

                Console.WriteLine("Menu:");
                Console.WriteLine("Mag - 1");
                Console.WriteLine("Wojownik - 2");

                do
                {
                    Console.WriteLine("Wybierz postać wciskając odpowiednią cyfrę:");

                    inputPlayerHero = Console.ReadLine();

                    switch(inputPlayerHero)
                    {
                        case "1":
                            heroes.Add(new Player(inputPlayerName, new Mage()));
                            isHeroChosen = true;
                            break;
                        case "2":
                            heroes.Add(new Player(inputPlayerName, new Warrior()));
                            isHeroChosen = true;
                            break;
                        default:
                            break;
                    }
                } while (!isHeroChosen);
            }
        }
    }
}
