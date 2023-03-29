using Day27Prac26.Interfaces;
using Day27Prac26.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Day27Prac26.Share
{
    internal class XmlDocumentSweets : IXmlSweets
    {
        private readonly XDocument _document;


        private string _xmlFilePath;


        public void Add(SweetsSet sweets)
        {

            XDocument xdoc = new XDocument();
            XElement sweetElem = new XElement("sweet1");
            XElement typeSweetElem = new XElement("TypeSweet");
            XText typeSweetText = new XText(sweets.TypeSweets);
            XElement typeFrillElem = new XElement("TypeFrill");
            XText typeFrillText = new XText(sweets.TypeFrill);
            XElement priceElem = new XElement("Price");
            XText priceText = new XText(sweets.Price.ToString());

            sweetElem.Add(typeSweetElem);
            typeSweetElem.Add(typeSweetText);
            sweetElem.Add(typeFrillElem);
            typeFrillElem.Add(typeFrillText);
            sweetElem.Add(priceElem);
            priceElem.Add(priceText);

            XElement sweet2Elem = new XElement("sweet2");
            XElement typeSweet2Elem = new XElement("TypeSweet", EnumSweets.Chocolate);
            XElement typeFrill2Elem = new XElement("TypeFrill", EnumTypeFrill.Foil);
            XElement price2Elem = new XElement("Price", "25");
            sweet2Elem.Add(typeSweet2Elem);
            sweet2Elem.Add(typeFrill2Elem);
            sweet2Elem.Add(price2Elem);

            XElement sweet = new XElement("sweets");
            sweet.Add(sweetElem);
            sweet.Add(sweet2Elem);
            xdoc.Add(sweet);
            xdoc.Save("sweets.xml");
            Console.WriteLine("add");

        }

        public void Load(string xmlDokPath)
        {
            Console.WriteLine($"Файл в котором были сохранены данные, находится {xmlDokPath} ");
        }
    }
}
