using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCarnival
{
    public class TeamMethods
    {
        private Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(@"TeamInput.json"));

        public TeamList CreateTeam(Game game)
        {
            switch (game.GameType)
            {
                case 1:
            }
            return null;
        }
    }
}