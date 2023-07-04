using GameRPG.Services;

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
