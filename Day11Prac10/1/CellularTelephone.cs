using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class CellularTelephone : Phone
    {
        string _phoneModel {get; set; }
        const int mult = 3;
        public CellularTelephone(string phoneModel, int k):base(k)
        {
            _phoneModel = phoneModel;
        }
   
      
        public override double Cost()
        {
            return base.Cost() * mult;
        }
        public override string ToString()
        {
            return $"Model: {_phoneModel}\n" + base.ToString();
        }
    }
}
