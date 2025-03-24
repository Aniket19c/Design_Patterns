﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public sealed class Singleton
    {

        public static Singleton instance=null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        private Singleton()
        {

        }
       public void Print(string msg)
        {
            Console.WriteLine(msg);

        }
    }
}
