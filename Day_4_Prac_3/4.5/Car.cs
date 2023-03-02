using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    class Car
    {

        public int _numberPlate;
        public string _color;
        public string _ownerName;
        public string _presence;
        public Car(int numberPlate, string color, string ownerName, string presence)
        {
            _numberPlate = numberPlate;
            _color = color;
            _ownerName = ownerName;
            _presence = presence;
        }
    }
}
