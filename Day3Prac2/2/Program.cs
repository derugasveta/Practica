using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1.Квитанция\n2.Накладная\n3.Счет");
            Console.WriteLine("Введите тип документа");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    Receipt receipt = new Receipt("Квитанция", new DateTime(23012023));

                    Console.WriteLine(receipt.Pay());
                    break;

                case 2:
                    Ivoice ivoice = new Ivoice("Накладная", new DateTime(29012005));
                    Console.WriteLine("1.Товарная накладная\n2.Транспортная накладная");
                    Console.WriteLine("Выберите накладную");
                    int ivoi = int.Parse(Console.ReadLine());
                    switch (ivoi)
                    {
                        case 1:
                            Console.WriteLine(ivoice.Fruit());
                            break;
                        case 2:
                            Console.WriteLine(ivoice.Machine());
                            Console.WriteLine(ivoice.Transport("Гродно"));
                            Console.WriteLine(ivoice.Transport1("Минск"));
                            break;
                        default:
                            Console.WriteLine("Таких накладных нет");
                            break;
                    }
                    break;
                case 3:
                    Check check = new Check("Счет", new DateTime(25022023));
                    Console.WriteLine("Введите, что хотите оплатить ");
                    string pay = Console.ReadLine();
                    if (pay == "Кредит" || pay == "кредит")
                    {
                        Console.WriteLine(check.GetInformationCredit());
                    }
                    else
                        Console.WriteLine(check.GetInformation(pay));

                    break;
                default:
                    Console.WriteLine("Такого типа документа нет");
                    break;
            }
        }
    }
}
