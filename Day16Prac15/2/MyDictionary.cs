using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class MyDictionary<K,V>
    {
        protected K[] keyArr ;

        protected V[] valueArr ;
   

        public void Add(K key , V val)
        {
            if (keyArr != null)
            {
                if (Array.IndexOf(keyArr, key) != -1)
                {
                    return;
                }
                Array.Resize(ref keyArr, keyArr.Length + 1);
                Array.Resize(ref valueArr, valueArr.Length + 1);
            }
            else
            {
                keyArr = new K[1];
                valueArr = new V[1];
            }
            keyArr[keyArr.Length - 1] = key;
            valueArr[valueArr.Length - 1] = val;
        }

   
        public V this[int index]
        {
            get
            {
                if (valueArr != null)
                {
                    if (0 <= index && index < keyArr.Length)
                    {
                        return valueArr[index];
                    }
                }
                return default(V);
            }
        }
        public int Count
        {
            get
            {
                if (keyArr != null)
                {
                    return keyArr.Length;
                }
                return 0;
            }
        }
    }
}
