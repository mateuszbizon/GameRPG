using GameRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Services
{
    class GameService : IGame
    {
        private bool isHeroChosen = false;
        private string inputPlayerName = "";
        private string inputPlayerHero = "";
        private readonly int amountOfPlayers = 5;
        private Player winner;

        Game game = new Game();

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

                    switch (inputPlayerHero)
                    {
                        case "1":
                            game.players.Add(new Player(inputPlayerName, new Mage()));
                            isHeroChosen = true;
                            break;
                        case "2":
                            game.players.Add(new Player(inputPlayerName, new Warrior()));
                            isHeroChosen = true;
                            break;
                        default:
                            break;
                    }
                } while (!isHeroChosen);
            }

            game.remainPlayers.AddRange(game.players);
        }

        public void Fight()
        {
            if (game.players.Count == 1)
            {
                winner = game.players[0];

                Console.WriteLine($"Wygrał gracz: {winner.name}");

                throw new WinnerWasCalled();
            }

            for (int i = 0; i < game.players.Count; i++)
            {
                if (i % 2 == 1 || i == game.players.Count - 1) continue;

                Player firstPlayer = game.players[i];
                Player secondPlayer = game.players[i + 1];

                Console.WriteLine($"Walka: {firstPlayer.name} vs {secondPlayer.name}");

                while (true)
                {
                    Console.WriteLine($"Atakuje: {firstPlayer.name}");

                    secondPlayer.chosenHero.SetHealth(secondPlayer.chosenHero.GetHealth() - firstPlayer.chosenHero.Attack());

                    Console.WriteLine($"Życie gracza {secondPlayer.name}: {secondPlayer.chosenHero.GetHealth()}");

                    if (secondPlayer.chosenHero.GetHealth() <= 0)
                    {
                        Console.WriteLine($"{secondPlayer.name} przegrał");
                        game.remainPlayers.Remove(secondPlayer);
                        firstPlayer.chosenHero.SetHealthToMax();
                        break;
                    }

                    Console.WriteLine($"Atakuje: {secondPlayer.name}");

                    firstPlayer.chosenHero.SetHealth(firstPlayer.chosenHero.GetHealth() - secondPlayer.chosenHero.Attack());

                    Console.WriteLine($"Życie gracza {firstPlayer.name}: {firstPlayer.chosenHero.GetHealth()}");

                    if (firstPlayer.chosenHero.GetHealth() <= 0)
                    {
                        Console.WriteLine($"{firstPlayer.name} przegrał");
                        game.remainPlayers.Remove(firstPlayer);
                        secondPlayer.chosenHero.SetHealthToMax();
                        break;
                    }
                }
                Console.WriteLine();
            }

            game.players = game.remainPlayers;
        }
    }
}
