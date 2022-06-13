using System;


namespace Coding
{
    class Program
    {

       public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter number");
             a = Convert.ToInt32 (Console.ReadLine());

            FindEvenOrOdd( a);



        }

        public static void FindEvenOrOdd(int a) {
            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Odd");
                Console.Read();
            }
        }








    }



}