using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public sealed class Singleton
    {
        private static int c=0;
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
            c++;
            Console.WriteLine(c.ToString());

        }
       public void Print(string msg)
        {
            Console.WriteLine(msg);

        }
    }
}
