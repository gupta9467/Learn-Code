using SportCarnival.Model;
using SportCarnival.RepositoryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCarnival.Repository
{
    public class TeamRepository
    {
        private readonly LearnCodeEntities _dbContext;

        public TeamRepository()
        {
            _dbContext = new LearnCodeEntities();
        }

        public TeamRepository(LearnCodeEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddTeam(List<Teams> teams)
        {
            Team teamData = GetAll().ToList().LastOrDefault();
            string name = teamData.name;
            foreach (Teams teamItem in teams)
            {
                Team team = new Team()
                {
                    teamId = teamItem.TeamId,
                    name = teamItem.TeamName,
                    eventId = 1,
                    gameId = (int)teamItem.GameType
                };
                _dbContext.Teams.Add(team);
                _dbContext.SaveChanges();
            }
        }

        public List<Team> GetTeam(int gameId, int eventId)
        {
            var team = _dbContext.Teams.Where(t => t.gameId == gameId && t.eventId == eventId).ToList();
            return team;
        }

        public List<Team> GetAll()
        {
            return _dbContext.Teams.ToList();
        }
    }
}