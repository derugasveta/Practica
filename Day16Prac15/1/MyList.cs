using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1;
namespace _1
{
    class MyList<T>
    {
        protected int index = 0;

        protected T[] arr = new T[100];
        public void Add(T value)
        {
            arr[index] = value;
            index++;
        }

        public void ShowValues()
        {
            for (int i = 0; i < index; i++)
                Console.WriteLine(arr[i]);
        }
        public T this[int index]
        {
            set
            {
                arr[index] = value;
            }

            get
            {
                return arr[index];
            }
        }

            //get
            //{
            //    // если индекс имеется в массиве
            //    if (index >= 0 && index < values.Length)
            //        return values[index]; // то возвращаем объект Person по индексу
            //    else
            //        throw new ArgumentOutOfRangeException(); // иначе генерируем исключение
            //}
            //set
            //{
            //    // если индекс есть в массиве
            //    if (index >= 0 && index < values.Length)
            //        values[index] = value;    // переустанавливаем значение по индексу
            //}
    }

}

