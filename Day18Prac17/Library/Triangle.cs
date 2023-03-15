using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Triangle
    {
        private int a;
        public int A { get => this.a; set => this.a = value; }

        public int B { get; init; }
        public int C { get; init; }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            B = b;
            C = c;
        }

        public double Perimeter()
        {
            return a + B + C;
        }
        public double Square()
        {
            double p = 0.5 * (a + B + C);
            return Math.Sqrt(p * (p - a) * (p - B) * (p - C));
        }

        public TryangleTypeEnum TypeTringle()
        {
            if (a == B && B == C && B == C)
            {
                return TryangleTypeEnum.Equilateral;
            }
            if (a == B || a == C || C == B)
            { return TryangleTypeEnum.Isosceles; }

            return TryangleTypeEnum.Scalene;
        }
    }
}
