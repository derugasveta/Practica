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
       

        protected T[] arr =Array.Empty<T>();
        public void Add(T value)
        {
            var newArray = new T[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            newArray[arr.Length] = value;
            arr = newArray;
        }

        internal static T[] GetArray(MyList<T> myList)
        {
            if (myList.arr != null)
            {
                return myList.arr;
            }
            return default(T[]);
        }

        public T this[int index]
        {
            get => arr[index];
            set => arr[index] = value;
        }
        public int Count
        {
            get { return arr.Length; }

        }

    }

}

