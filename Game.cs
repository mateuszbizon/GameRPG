using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class Game
    {
        public List<Player> players;
        public List<Player> remainPlayers = new List<Player>();
        private readonly int amountOfPlayers = 5;
        private string inputPlayerName = "";
        private string inputPlayerHero = "";
        private bool isHeroChosen = false;
        private Player winner;

        public Game() { 
            players = new List<Player>();
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
                            players.Add(new Player(inputPlayerName, new Mage()));
                            isHeroChosen = true;
                            break;
                        case "2":
                            players.Add(new Player(inputPlayerName, new Warrior()));
                            isHeroChosen = true;
                            break;
                        default:
                            break;
                    }
                } while (!isHeroChosen);
            }

            remainPlayers.AddRange(players);
        }

        public void Fight()
        {
            if (players.Count == 1)
            {
                winner = players[0];

                Console.WriteLine($"Wygrał gracz: {winner.name}");

                throw new WinnerWasCalled();
            }

            for (int i=0; i < players.Count; i++)
            {
                if (i % 2 == 1 || i == players.Count - 1) continue;

                Player firstPlayer = players[i];
                Player secondPlayer = players[i+1];

                Console.WriteLine($"Walka: {firstPlayer.name} vs {secondPlayer.name}");

                while (true)
                {
                    Console.WriteLine($"Atakuje: {firstPlayer.name}");

                    secondPlayer.chosenHero.SetHealth(secondPlayer.chosenHero.GetHealth() - firstPlayer.chosenHero.Attack());

                    Console.WriteLine($"Życie gracza {secondPlayer.name}: {secondPlayer.chosenHero.GetHealth()}");

                    if (secondPlayer.chosenHero.GetHealth() <= 0)
                    {
                        Console.WriteLine($"{secondPlayer.name} przegrał");
                        remainPlayers.Remove(secondPlayer);
                        firstPlayer.chosenHero.SetHealthToMax();
                        break;
                    }

                    Console.WriteLine($"Atakuje: {secondPlayer.name}");

                    firstPlayer.chosenHero.SetHealth(firstPlayer.chosenHero.GetHealth() - secondPlayer.chosenHero.Attack());

                    Console.WriteLine($"Życie gracza {firstPlayer.name}: {firstPlayer.chosenHero.GetHealth()}");

                    if (firstPlayer.chosenHero.GetHealth() <= 0)
                    {
                        Console.WriteLine($"{firstPlayer.name} przegrał");
                        remainPlayers.Remove(firstPlayer);
                        secondPlayer.chosenHero.SetHealthToMax();
                        break;
                    }                 
                }
                Console.WriteLine();
            }

            players = remainPlayers;
        }
    }
}
