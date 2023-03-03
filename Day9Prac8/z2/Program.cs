using System;
using System.Diagnostics;

namespace z1
{

    class program
    {
        enum JobTitle
        {
            Director = 140,
            Accountant = 120,
            Engineer = 135,
            Manager = 130
        }
       static string AskForBonus(JobTitle worker, int hours)
        {
            if ((int)worker < hours)
            {
                return "Начислить премию";
            }

            return "Премию не начислять";

        }
       static void Main()
        {
            Console.WriteLine("Выберите вашу должность: \n1. Директор \n2. Бухгалтер \n3. Инженер \n4. Менеджер");
            int workNumber = int.Parse(Console.ReadLine());
            var workers=Enum.GetValues(typeof(JobTitle)).Cast<JobTitle>().ToList();
            var worker = workers[workNumber - 1];

            Console.WriteLine("Введите количество рабочих часов");
            int hours = int.Parse(Console.ReadLine());
           var message= AskForBonus(worker,hours);
            Console.WriteLine(message);
        }
    }
}

