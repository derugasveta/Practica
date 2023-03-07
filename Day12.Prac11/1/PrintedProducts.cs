using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class PrintedProducts
    {
        public string _name { get; set; }

        public PrintedProducts(string name)
        {
            _name = name;
        }
        public override string ToString()
        {
            return $"Name: {_name}";
        }
    }
}
