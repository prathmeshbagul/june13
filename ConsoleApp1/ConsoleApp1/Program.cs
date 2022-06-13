using System;

namespace Coding
{
    class Program
    {

        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter number");
            a = Convert.ToInt32(Console.ReadLine());

           bool result = IsEven(a);
            if (result == true)
            {
                Console.WriteLine("Even Number");
            }

            else {
                Console.WriteLine("Odd Number");
            }
        }
        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
           
            {                  
                return false;
            }

        }

    }

}