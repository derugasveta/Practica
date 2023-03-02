using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Check : Document
    {
        public Check(string typeOfDocument, DateTime yearОfIssue) : base(typeOfDocument, yearОfIssue)
        {

        }

        public string GetInformation(string n)
        {
            return "Счет об уплате" + n;
        }
        public string GetInformationCredit()
        {
            Console.WriteLine("Введить сумму кредита:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму, которую хотите отплатить: ");
            double b = double.Parse(Console.ReadLine());
            double c = a - b;
            if (a == b)
                return "Вы погасили кредит";
            else
                return "Ваш кредит еще не погашен, вам осталось " + c;


        }



    }
}
