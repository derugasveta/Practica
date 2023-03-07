using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class B : A
    {
        private double _d { get; set; }
        public B(double d, double a, double b) : base(a, b)
        {
            _d = d;
        }
        public B(double d)
        {
            _d = d;
        }
        public double c2
        {
            get
            {
                int counter = 0;
                do 
                { 
                    _a = _a + _b + _d; 
                }
                while (++counter < 4);
                return _a;
            }

        }
    }
}
