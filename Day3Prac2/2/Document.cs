using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Document
    {
        string _name { get; set; }
        string _typeOfDocument { get; set; }
        DateTime _yearОfIssue { get; set; }

        public Document(string typeOfDocument, DateTime yearОfIssue)
        {

            _typeOfDocument = typeOfDocument;
            _yearОfIssue = yearОfIssue;

        }

    }
}
