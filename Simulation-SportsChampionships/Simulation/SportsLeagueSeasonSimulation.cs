using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;
using SimulationSportsChampionships.Seasons;

namespace SimulationSportsChampionships.Simulation
{
    public static class SportsLeagueSeasonSimulation
    {
        public static SimulationOutcome GetSportsLeagueSimulationOutcome(string sportsLeague, int seasonStartYear)
        {
            var randomSeed = SystemRandomSource.Default;

            // Initialize the simulation
            var simulationOutCome = new SimulationOutcome { 
                SimulationID = Guid.NewGuid().ToString(),
                SeasonStartYear = seasonStartYear
            };

            // Get basketball season league structure
            SportsLeagueSeason sportsLeagueRules = new SportsLeagueSeason();
                
            if  (sportsLeague == "football")
            {
                sportsLeagueRules = Seasons.SportsSeasonRules.GetFootballSeasonRules(seasonStartYear);
            }
            else
            {
                sportsLeagueRules = Seasons.SportsSeasonRules.GetBasketballSeasonRules(seasonStartYear);
            }

            // Simulate if made playoffs
            var probabilityOfPlayOffsDistribution = new Bernoulli(sportsLeagueRules.ProbabilityOfPlayoffs, randomSeed);
            var isPlayoffTeam = Convert.ToBoolean(probabilityOfPlayOffsDistribution.Sample());
            simulationOutCome.IsPlayoffTeam = isPlayoffTeam;

            if (simulationOutCome.IsPlayoffTeam)
            {
                // Simulate if playoff team
                var probabilityOfPlayOffsByeDistribution = new Bernoulli(sportsLeagueRules.ProbabilityOfPlayoffsBye, randomSeed);
                var test = probabilityOfPlayOffsByeDistribution.Sample();
                var isPlayoffTeamWithBye = Convert.ToBoolean(probabilityOfPlayOffsByeDistribution.Sample());
                simulationOutCome.IsPlayoffTeamWithBye = isPlayoffTeamWithBye;

                // Simulate if championship winning team
                var numberOfPlayoffRoundWinsForChampionship =
                    sportsLeagueRules.NumberOfPlayoffRoundsWithChampionship -(isPlayoffTeamWithBye ? 1 : 0);

                var probabilityOfChampionship = new Binomial(0.5, numberOfPlayoffRoundWinsForChampionship, randomSeed);
                var numberOfSimulatedPlayoffWins = probabilityOfChampionship.Sample();
                simulationOutCome.IsChampionshipWinningTeam =
                    (numberOfSimulatedPlayoffWins == numberOfPlayoffRoundWinsForChampionship) ? true : false;
            }

            return simulationOutCome;
        }
    }
}
