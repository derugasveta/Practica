using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal interface IObserver
    {
        void Update(Blogger blogger);
        void Subscribing(Blogger blogger);
        void Unsubscribing(Blogger blogger);
    }
}
