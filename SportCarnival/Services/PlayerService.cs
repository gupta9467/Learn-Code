using SportCarnival.Model;
using SportCarnival.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCarnival.Services
{
    public class PlayerService
    {
        public void AddPlayer(Game game)
        {
            PlayerRepository playerRepository = new PlayerRepository();
            playerRepository.AddPlayer(game.Players);
        }
    }
}