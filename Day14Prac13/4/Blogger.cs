using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4;

namespace _4
{
    internal class Blogger
    {

        delegate void PublicPhoto(Blogger blogger);
        event PublicPhoto? pb;

        private string _name;

        public string Name { get => _name; }

        public Blogger(string name)
        {
            _name = name;
        }

        public void Attach(IObserver observer)
        {
            pb += observer.Update;
            observer.Subscribing(this);
        }

        public void Detach(IObserver observer)
        {
            pb -= observer.Update;
            observer.Unsubscribing(this);
        }
        public void Pub(bool tr)
        {
            if (tr == true)
            Console.WriteLine($"Blogger {_name} post a photo ");
            else
                Console.WriteLine("Blogger unpost a photo");

        }

    }
}
