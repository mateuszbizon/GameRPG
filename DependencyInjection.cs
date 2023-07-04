using GameRPG.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class DependencyInjection
    {
        GameService gameService = new GameService();

        public DependencyInjection() { }

        public void ChooseHero()
        {
            gameService.ChooseHero();
        }

        public void Fight()
        {
            gameService.Fight();
        }
    }
}
