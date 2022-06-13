using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Class1
    {
        static void Main(string[] args) {

            var x = 34.2;
            Console.WriteLine(x);
            var y = 27.8;
            Console.WriteLine(y);
            var result = x + y;
            Console.WriteLine("x" +"+"+ "y");
            Console.WriteLine(result );   

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]} !");
            }
            else
            {
                Console.WriteLine("Hello !");
            }
        
        
        }
    }
}
