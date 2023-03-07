using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Airplane:IComparable<Airplane>
    {
        private string _destinationName;
        private int _flightNumber;
        private TimeOnly _departureTime;


        public Airplane()
        {
        }

        public Airplane(string destinationName, int flightNumber, TimeOnly departureTime)
        {
            _destinationName = destinationName;
            _flightNumber = flightNumber;
            _departureTime = departureTime;

        }
        public string DestinationName
        {
            get { return _destinationName; }
            set { _destinationName = value; }

        }
        public int FlightNumber
        {
            get { return _flightNumber; }
            set { _flightNumber = value; }

        }
        public TimeOnly DepartureTime
        {
            get { return _departureTime; }
            set { _departureTime = value; }

        }

        public int CompareTo(Airplane? other)
        {
            var flightNumerComparer = _flightNumber.CompareTo(other.FlightNumber);
            if (flightNumerComparer != 0)
            {
                return flightNumerComparer;
            }
            var departureTimeComparer = _departureTime.CompareTo(other.DepartureTime);
            if (departureTimeComparer != 0)
            {
                return departureTimeComparer;
            }
            return _destinationName.CompareTo(other.DestinationName);
        }

        public override string ToString()
        {
            return $"{DestinationName} | {FlightNumber} | {DepartureTime.ToShortTimeString()} ";
        }
    }
}
