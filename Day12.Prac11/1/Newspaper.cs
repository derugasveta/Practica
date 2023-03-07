using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Newspaper : PrintedProducts
    {
        public int _numberOfSheets { get; set; }
        public double _costPerSheet { get; set; }
        public int _circulation { get; set; }
        public double cost;
        public Newspaper(int numberOfSheets, double costPerSheet, int circulation, string name): base( name )
        {
            _numberOfSheets = numberOfSheets;
            _costPerSheet = costPerSheet;
            _circulation = circulation;
        }
        public double NewapaperCirculationCost()
        {
            return (_numberOfSheets * _costPerSheet) * _circulation;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nNumber of sheets: {_numberOfSheets} \nCost per sheet: {_costPerSheet} \nCirculation: {_circulation}";
        }

    }
}
