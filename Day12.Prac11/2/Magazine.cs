using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Magazine : PrintedProducts
    {
        public int _circulation { get; set; }
        public decimal _price { get; set; }
        

        public Magazine(int circulation, decimal price, string name) : base(name)
        {
            _circulation = circulation;
            _price = price;
        }
       
        public override string ToString()
        {
            return $"{base.ToString()}\nCirculation: {_circulation} \nPrice: {_price}";

        }
        //public double AverageСostОfMagazines()
        //{

        //}

        public override decimal Cost()
        {
            return _circulation * _price;
        }
    }
}
