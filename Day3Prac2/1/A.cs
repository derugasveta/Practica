using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class A
    {
        public double _a { get; set; }
        public double _b { get; set; }
        public A(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public double Calculation(double a, double b)
        {
            return a * Math.Sqrt(b) + Math.Sin(b);
        }
        public double Erection(double a, double b)
        {
            double c = Math.Pow(a / b, 3);
            return c;
        }
    }
}
