using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class MyInfo
    {
        public delegate void Delegate(string message);
        public event Delegate NameСhange = delegate { };
        private string _name;
        public string Name
        { 
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    NameСhange($"Имя было изменено на {_name}");
                    return;
                }
                NameСhange($"Имя не изменилось");
            }
        }

        public MyInfo(string name)
        {
            _name = name;
        }
       
    }
}
