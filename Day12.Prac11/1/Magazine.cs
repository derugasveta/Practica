using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Magazine:PrintedProducts
    {
        public int _circulation { get; set; }
        public double _price { get; set; }
        public double cost;

        public Magazine(int circulation, double price, string name) : base(name)
        {
            _circulation = circulation;
            _price = price;
        }
        public double CirculationCost()
        {
          return _circulation * _price;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nCirculation: {_circulation} \nPrice: {_price}";
            
        }


    }
}
