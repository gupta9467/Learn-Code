using SportCarnival.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCarnival.Model
{
    public class Game
    {
        public GameType GameType { get; set; }

        public List<Player> Players { get; set; }
    }
}