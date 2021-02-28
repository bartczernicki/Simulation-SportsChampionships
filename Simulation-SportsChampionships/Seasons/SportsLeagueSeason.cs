using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulationSportsChampionships.Seasons
{
    public class SportsLeagueSeason
    {
        private int numberofTeamsInLeague;
        private int numberofTeamsInLeagueInPlayoffs;
        private int numberofTeamsInLeagueInPlayoffsWithBye;

        /// <summary>
        /// Start year of Sports League Season
        /// </summary>
        /// 
        public int StartYear { get; set; }
        /// <summary>
        /// Count of number of all of the teams in the NBA
        /// </summary>
        public int NumberofTeamsInLeague
        {
            get { return numberofTeamsInLeague; }
            set { numberofTeamsInLeague = value; }
        }

        /// <summary>
        /// Count of number of all of the teams in the NBA
        /// </summary>
        public int NumberofTeamsInLeagueInPlayoffs
        {
            get { return numberofTeamsInLeagueInPlayoffs; }
            set { numberofTeamsInLeagueInPlayoffs = value; }
        }

        /// <summary>
        /// Count of number of all of the teams in the NBA
        /// </summary>
        public int NumberofTeamsInLeagueInPlayoffsWithBye
        {
            get { return numberofTeamsInLeagueInPlayoffsWithBye; }
            set { numberofTeamsInLeagueInPlayoffsWithBye = value; }
        }


        /// <summary>
        /// Probability of making the playoffs (number of teams in playoffs/NumberofTeamsInLeague
        /// </summary>
        public double ProbabilityOfPlayoffs
        { 
            get { return (double) this.numberofTeamsInLeagueInPlayoffs / this.numberofTeamsInLeague; }
        }

        /// <summary>
        /// Probability of making the playoffs (number of teams in playoffs/NumberofTeamsInLeague
        /// </summary>
        public double ProbabilityOfPlayoffsBye
        {
            get { return (double) this.numberofTeamsInLeagueInPlayoffsWithBye / this.numberofTeamsInLeagueInPlayoffs; }
        }

        /// <summary>
        /// Number of rounds to championship
        /// </summary>
        public int NumberOfPlayoffRoundsWithChampionship { get; set; }
    }
}
