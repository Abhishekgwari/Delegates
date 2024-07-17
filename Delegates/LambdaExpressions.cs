using System;

namespace Delegates
{   
    
    internal class LambdaExpressions
    {
    

        static void Main(String[] args)
        {
            GreetingDelegate obj = ( name) =>  // => this is lamda expression is for aanonymous method
                                               // short hand delegates
            {
                return "Hello " + name + " a very good morning";
            };

          string str =  obj.Invoke("Abhishek");
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
