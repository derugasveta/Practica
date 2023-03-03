using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.Providers
{
    internal class MemoryMarshProvider
    {
        public static List<Marsh> GetMarshes()
        {
            return new List<Marsh>()
            {  new Marsh("Гродно","Минск", 1 ),
               new Marsh("Гродно", "Мосты", 2),
               new Marsh("Гродно", "Питер", 3),
               new Marsh("Гродно", "Гомель", 4),
               new Marsh("Гродно", "Волковыск", 5)
            };
        }
    }
}
