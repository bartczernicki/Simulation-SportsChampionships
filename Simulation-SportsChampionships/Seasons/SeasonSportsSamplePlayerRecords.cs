using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulationSportsChampionships.Seasons
{
    public static class SeasonSportsSamplePlayerRecords
    {
        public static int GetSportsLegendRecords(string playerName, string recordType)
        {
            var playerRecordEventValue = 0;

            switch (playerName)
            {
                case var exp when (playerName == "Tom Brady" && recordType == "playoffs"):
                    playerRecordEventValue = 10;
                    break;
                case var exp when (playerName == "Tom Brady" && recordType == "championships"):
                    playerRecordEventValue = 4;
                    break;
                case var exp when (playerName == "Lebron James" && recordType == "playoffs"):
                    playerRecordEventValue = 9;
                    break;
                case var exp when (playerName == "Lebron James" && recordType == "championships"):
                    playerRecordEventValue = 4;
                    break;
                case var exp when (playerName == "Bill Russell" && recordType == "playoffs"):
                    playerRecordEventValue = 10;
                    break;
                case var exp when (playerName == "Bill Russell" && recordType == "championships"):
                    playerRecordEventValue = 9;
                    break;
            }

            return playerRecordEventValue;
        }
    }
}
