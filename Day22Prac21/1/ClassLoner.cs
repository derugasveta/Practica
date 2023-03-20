﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class ClassLoner
    {
        private static ClassLoner uniqueInstance;
        public string Name { get; set; }
        private ClassLoner()
        {

        }
        public static ClassLoner GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ClassLoner();
            }
            return uniqueInstance;
        }
    }
}
