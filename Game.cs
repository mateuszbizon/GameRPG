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

        public Game() { 
            players = new List<Player>();
        }   
    }
}
