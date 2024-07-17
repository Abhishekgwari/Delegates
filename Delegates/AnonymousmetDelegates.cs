using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate string GreetingDelegate(string name);
    internal class AnonymousmetDelegates
    {
      
        static void Main(string[] args)

        {
            GreetingDelegate obj = delegate (string name)         //  a method without name  
            {
                return "Hello " + name + " a very good morning";
            };
            string str = obj.Invoke("Abhishek");
            Console.WriteLine(str);
            Console.ReadLine();


        }


    }
}
