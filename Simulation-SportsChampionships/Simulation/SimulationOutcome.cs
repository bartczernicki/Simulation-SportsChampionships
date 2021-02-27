using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulationSportsChampionships.Simulation
{
    public class SimulationOutcome
    {
        public string SimulationID { get; set; }
        public int SeasonStartYear { get; set; }
        public bool IsPlayoffTeam { get; set; } = false;
        public bool IsPlayoffTeamWithBye { get; set; } = false;
        public bool IsChampionshipWinningTeam { get; set; } = false;
    }
}
