using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Subscriber1: IObserver
    {
        private string _name;

        public Subscriber1(string name)
        {
            _name = name;
        }

        public void Subscribing(Blogger blogger) => Console.WriteLine($"Подписчик {_name} подписался на блогера: {blogger.Name} ");

        public void Unsubscribing(Blogger blogger) => Console.WriteLine($"Подписчик {_name} отписался от блогера: {blogger.Name}");
        public void Update(Blogger blogger)
        {
            Console.WriteLine($"Подписчик {_name} был уведомлен о публикации фото ");
        }
    }
}
