using SportCarnival.Enums;
using SportCarnival.RepositoryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameType = SportCarnival.RepositoryData.GameType;

namespace SportCarnival.Model
{
    public class Game
    {
        public GameTypes GameType { get; set; }

        public List<Player> Players { get; set; }
    }
}