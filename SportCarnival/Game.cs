using SportCarnival.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCarnival
{
    public class Game
    {
        public GameType GameType { get; set; }

        public List<Player> Players { get; set; }
    }

    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
    }

    public class TeamList
    {
        public List<Team> Teams { get; set; }
        public int Total { get; set; }
    }

    public class Team : Game
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; }
    }
}