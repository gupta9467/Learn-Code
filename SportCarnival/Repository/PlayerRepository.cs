using SportCarnival.RepositoryData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCarnival.Repository
{
    public class PlayerRepository
    {
        private readonly LearnCodeEntities _dbContext;

        public PlayerRepository()
        {
            _dbContext = new LearnCodeEntities();
        }

        public PlayerRepository(LearnCodeEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddPlayer(List<Player> players)
        {
            _dbContext.Players.AddRange(players);
            return _dbContext.SaveChanges();
        }
    }
}