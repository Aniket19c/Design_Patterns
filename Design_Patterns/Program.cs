using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton s1= new Singleton();
            //s1.Print("this is first message");
            //Singleton s2= new Singleton();
            //s2.Print("this is second message");
            Singleton s1 = Singleton.GetInstance;
            s1.Print("hi this is the first message");
            Singleton s2= Singleton.GetInstance;
            s2.Print("HI THIS SI SECOND MESSAGE");

            Console.WriteLine("Before accessing message.");
            Console.WriteLine(Lazy.Message); // First time, initializes
            Console.WriteLine(Lazy.Message); // Second time, reuses
        }
    }
}
