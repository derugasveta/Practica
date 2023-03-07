using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AirplainsComparers
{
    internal class AirplainDepartureTimeComparer : IComparer<Airplane>
    {
        public int Compare(Airplane? firstArplain, Airplane? secomdAirplain)
        {
            return firstArplain.DestinationName.CompareTo(secomdAirplain.DestinationName);
        }
    }
}
