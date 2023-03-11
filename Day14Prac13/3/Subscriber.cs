using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Subscriber
    {
        public string  Name { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        ////public void Show(string message)
        //{
        //    Console.WriteLine($"{Name} see {message}");
        //}
    }
}
