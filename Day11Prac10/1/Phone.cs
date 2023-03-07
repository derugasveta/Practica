using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Phone
    {
        public int _k { get; set; }
        const int  koef= 40;

        public Phone(int k)
        {
            _k = k;
         
        }       
       
        public virtual double Cost()
        {
            
            return koef * Math.Log(_k);
        }

        public override string ToString()
        {
            return $"Number of functions {_k}";
        }
    }
}
