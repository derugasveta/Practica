using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Newspaper : PrintedProducts
    {
        public int _numberOfSheets { get; set; }
        public decimal _costPerSheet { get; set; }
        public int _circulation { get; set; }
        
        public Newspaper(int numberOfSheets, decimal costPerSheet, int circulation, string name) : base(name)
        {
            _numberOfSheets = numberOfSheets;
            _costPerSheet = costPerSheet;
            _circulation = circulation;
        }
       
        public override string ToString()
        {
            return $"{base.ToString()}\nNumber of sheets: {_numberOfSheets} \nCost per sheet: {_costPerSheet} \nCirculation: {_circulation}";
        }
        //public double AverageСostОfNewpaper()
        //{

        //}

        public override decimal Cost()
        {
            return (_numberOfSheets * _costPerSheet) * _circulation;
        }
    }
}
