using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class GenricDelegates
    {

        
      
        
        static void Main(string[] args) 
        {
            Func<int,float,double ,double> obj1 = (x,y,z)=>
            {

            return x + y + z; };
        
            double result = obj1.Invoke(100, 34.5f, 193.465);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);

            };
            obj2.Invoke(100, 34.5f, 193.465);

            Predicate<string> obj3 = (str) =>
            {
                if ((str.Length > 5))

                    return true;
                return false;
            };
            bool status = obj3.Invoke("ABHISHEK"); 

            Console.WriteLine(status);

            Console.ReadLine();


        }
    }
}
