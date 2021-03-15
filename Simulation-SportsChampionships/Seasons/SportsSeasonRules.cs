using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulationSportsChampionships.Seasons
{
    public static class SportsSeasonRules
    {
        public static SportsLeagueSeason GetBasketballSeasonRules (int startYear, string division)
        {
            var basketBallSeason = new SportsLeagueSeason();
            basketBallSeason.StartYear = startYear;

            if (division == "East")
            {
                // East had 3 of 4 teams make playoffs, West had 3 of 5 teams make playoffs.
                basketBallSeason.UseDivisionForPlayoffs = true;
                basketBallSeason.NumberofTeamsInDivisionInPlayoffs = 3;
                basketBallSeason.NumberofTeamsInDivision = 4;
            }
            else // West
            {
                // East had 3 of 4 teams make playoffs, West had 3 of 5 teams make playoffs.
                basketBallSeason.UseDivisionForPlayoffs = false;
                basketBallSeason.NumberofTeamsInDivisionInPlayoffs = 3;
                basketBallSeason.NumberofTeamsInDivision = 5;
            }


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
                    // New playoff model with additional West team.
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

        public static SportsLeagueSeason GetFootballSeasonRules(int startYear)
        {
            var footballSeason = new SportsLeagueSeason();
            footballSeason.StartYear = startYear;

            switch (startYear)
            {
                case var exp when (startYear >= 1970 && startYear < 1976):
                    footballSeason.NumberofTeamsInLeague = 26;
                    footballSeason.NumberofTeamsInLeagueInPlayoffs = 8;
                    footballSeason.NumberofTeamsInLeagueInPlayoffsWithBye = 0;
                    footballSeason.NumberOfPlayoffRoundsWithChampionship = 3;
                    break;
                case var exp when (startYear >= 1976 && startYear < 1978):
                    footballSeason.NumberofTeamsInLeague = 28;
                    footballSeason.NumberofTeamsInLeagueInPlayoffs = 8;
                    footballSeason.NumberofTeamsInLeagueInPlayoffsWithBye = 0;
                    footballSeason.NumberOfPlayoffRoundsWithChampionship = 3;
                    break;
                case var exp when (startYear >= 1978 && startYear < 1981):
                    footballSeason.NumberofTeamsInLeague = 28;
                    footballSeason.NumberofTeamsInLeagueInPlayoffs = 10;
                    footballSeason.NumberofTeamsInLeagueInPlayoffsWithBye = 6;
                    footballSeason.NumberOfPlayoffRoundsWithChampionship = 3;
                    break;
                case var exp when (startYear >= 2002 && startYear < 2021):
                    footballSeason.NumberofTeamsInLeague = 32;
                    footballSeason.NumberofTeamsInLeagueInPlayoffs = 12;
                    footballSeason.NumberofTeamsInLeagueInPlayoffsWithBye = 4;
                    footballSeason.NumberOfPlayoffRoundsWithChampionship = 4;
                    break;
                // Covid-19 season, 2 extra playoff teams, 2 less byes (only for #1 seed)
                case 2021:
                    footballSeason.NumberofTeamsInLeague = 32;
                    footballSeason.NumberofTeamsInLeagueInPlayoffs = 14;
                    footballSeason.NumberofTeamsInLeagueInPlayoffsWithBye = 2;
                    footballSeason.NumberOfPlayoffRoundsWithChampionship = 4;
                    break;
                default:
                    break;
            }

            return footballSeason;
        }
    }
}
