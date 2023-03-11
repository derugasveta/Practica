using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    class Car
    {

        private int _numberPlate;
        private string _color;
        private string _ownerName;
        private string _presence;

        public int NumberPlate => _numberPlate;
        public string Color => _color;
        public string OwnerName => _ownerName;
        public string Presence => _presence;

        public Car(int numberPlate, string color, string ownerName, string presence)
        {
            _numberPlate = numberPlate;
            _color = color;
            _ownerName = ownerName;
            _presence = presence;
        }
    }
}
