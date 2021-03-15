using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulationSportsChampionships.Seasons
{
    public class SportsLeagueSeason
    {
        // General
        private int numberofTeamsInLeague;
        private int numberofTeamsInLeagueInPlayoffs;
        private int numberofTeamsInLeagueInPlayoffsWithBye;

        // Division Edge Cases for NBA 1961-1965
        private int numberofTeamsInDivision;
        private int numberOfTeamsInDivisionInPlayoffs;

        /// <summary>
        /// Start year of Sports League Season
        /// </summary>
        /// 
        public int StartYear { get; set; }

        public int NumberofTeamsInDivision
        {
            get { return numberofTeamsInDivision; }
            set { numberofTeamsInDivision = value; }
        }

        /// <summary>
        /// Count of number of all of the teams in the NBA
        /// </summary>
        public int NumberofTeamsInLeague
        {
            get { return numberofTeamsInLeague; }
            set { numberofTeamsInLeague = value; }
        }

        /// <summary>
        /// Count of number of the teams in the division
        /// </summary>
        public int NumberofTeamsInDivisionInPlayoffs
        {
            get { return numberOfTeamsInDivisionInPlayoffs; }
            set { numberOfTeamsInDivisionInPlayoffs = value; }
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
            get 
            {
                if (this.UseDivisionForPlayoffs)
                {
                    return (double)this.numberOfTeamsInDivisionInPlayoffs / this.numberofTeamsInDivision;
                }
                else
                {
                    return (double)this.numberofTeamsInLeagueInPlayoffs / this.numberofTeamsInLeague;
                }
            }
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

        public bool UseDivisionForPlayoffs { get; set; } = false;
    }
}
