using System;

namespace _OVERALL__05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string xString;
            Console.WriteLine("Enter elements of the fibonacci sequence: ");
            xString = Console.ReadLine();
            int.TryParse(xString, out x);

            //Print
            for (int i = 0; i < x; ++i)
                Console.WriteLine(Fibonacci(i));
            Console.ReadKey();
        }

        static long Fibonacci(int n)
        {
            //F0 = 0, F1 = 1
            if (n == 0) return 0;
            if (n == 1) return 1;

            // In other cases, call the function twice
            // recursively to obtain the element values of F(n-1) + F(n-2)
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
