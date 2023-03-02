using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Ivoice : Document
    {

        public Ivoice(string typeOfDocument, DateTime yearОfIssue) : base(typeOfDocument, yearОfIssue)
        {

        }

        public string GetInformation()
        {
            return "Таварная накладная";
        }
        public string GetInformation2()
        {
            return "Транспортная накладная";
        }

        public string Fruit()
        {
            return "Накладная на получение фруктов";
        }
        public string Machine()
        {
            return "Накладная на запчасти";
        }
        public string Transport(string a)
        {
            return "Точка отправления товара: " + a;

        }
        public string Transport1(string b)
        {
            return "Точка прибытия: " + b;
        }




    }
}
