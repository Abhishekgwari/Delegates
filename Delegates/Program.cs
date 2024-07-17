using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Step 1 Defining  a delegate
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string name);
    internal class Program
    {
        public void AddNums(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "hello" + name;
        } 
        static void Main(string[] args)
        {
            Program p = new Program();
           
            AddDelegate ad = new AddDelegate(p.AddNums);
            ad(100, 50);

            SayDelegate sd = new SayDelegate(Program.SayHello);
            string str = sd("Abhishek");
            Console.WriteLine(str);

           
   

            Console.ReadLine();
        }
    }
}
