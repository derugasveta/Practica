using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Receipt : Document
    {
        public Receipt(string typeOfDocument, DateTime yearОfIssue) : base(typeOfDocument, yearОfIssue)
        {

        }

        public string Pay()
        {
            return "Квитанци о выплате алиментов";
        }

    }
}
