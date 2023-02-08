using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCarnival.Model
{
    public class Team : Game
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; }
    }
}