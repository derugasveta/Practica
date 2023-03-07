using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Provider
    {
        public static List<Airplane> GetAiroplants()
        {
            return new List<Airplane>()
            {  new Airplane("Минск",581558,new TimeOnly(20,30)),
               new Airplane("Стамбул",562545,new TimeOnly(19,45)),
               new Airplane("Париж",526485,new TimeOnly(21,00)),
               new Airplane("Лондон",523648,new TimeOnly(01,20)),
               new Airplane("Гродно",635241,new TimeOnly(05,40))
            };
        }
    }
}
