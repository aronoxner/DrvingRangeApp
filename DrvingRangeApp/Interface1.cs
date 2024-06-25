using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrvingRangeApp
{
    interface TrendFunctions
    {
        string ClubTrend(List<SwingData> list, Club clubChoice);
        string ShotTrend(List<SwingData> list, Club clubChoice);
        string FlightTrend(List<SwingData> list, Club clubChoice);
        int DistanceTrend(List<SwingData> list, Club clubChoice);
    }
    public class Trends : TrendFunctions
    {
        public string ClubTrend(List<SwingData> list, Club clubChoice)
        {
            throw new NotImplementedException();
        }

        public int DistanceTrend(List<SwingData> list, Club clubChoice)
        {
            throw new NotImplementedException();
        }

        public string FlightTrend(List<SwingData> list, Club clubChoice)
        {
            throw new NotImplementedException();
        }

        public string ShotTrend(List<SwingData> list, Club clubChoice)
        {
            throw new NotImplementedException();
        }
    }
}
