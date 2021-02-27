using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulationSportsChampionships.Seasons
{
    public static class BasketballSeasonsRules
    {
        public static BasketballSeason GetBasketballSeasonRules (int startYear)
        {
            var basketBallSeason = new BasketballSeason();
            basketBallSeason.StartYear = startYear;

            switch (startYear)
            {
                case 1959:
                case 1960:
                    basketBallSeason.NumberofTeamsInLeague = 8;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffs = 6;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffsWithBye = 2;
                    basketBallSeason.NumberOfPlayoffRoundsWithChampionship = 3;
                    break;
                case 1961:
                case 1962:
                case 1963:
                case 1964:
                case 1965:
                    basketBallSeason.NumberofTeamsInLeague = 9;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffs = 6;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffsWithBye = 2;
                    basketBallSeason.NumberOfPlayoffRoundsWithChampionship = 3;
                    break;
                case 1966:
                    basketBallSeason.NumberofTeamsInLeague = 10;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffs = 8;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffsWithBye = 0;
                    basketBallSeason.NumberOfPlayoffRoundsWithChampionship = 3;
                    break;
                case 1967:
                    basketBallSeason.NumberofTeamsInLeague = 12;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffs = 8;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffsWithBye = 0;
                    basketBallSeason.NumberOfPlayoffRoundsWithChampionship = 3;
                    break;
                case 1968:
                    basketBallSeason.NumberofTeamsInLeague = 14;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffs = 8;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffsWithBye = 0;
                    basketBallSeason.NumberOfPlayoffRoundsWithChampionship = 3;
                    break;
                case var exp when startYear >= 2009:
                    basketBallSeason.NumberofTeamsInLeague = 30;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffs = 16;
                    basketBallSeason.NumberofTeamsInLeagueInPlayoffsWithBye = 0;
                    basketBallSeason.NumberOfPlayoffRoundsWithChampionship = 4;
                    break;
                default:
                    break;
            }

            return basketBallSeason;
        }
    }
}
