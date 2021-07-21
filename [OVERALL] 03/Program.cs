using System;

namespace _OVERALL__03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get value of n
            int n;
            Console.Write("Insert value of n: ");
            string text = Console.ReadLine();
            if (!int.TryParse(text, out n)) throw new ArgumentException("n is not an integer!\n");

            // Calculate the factorial n number and print it on the screen.
            int factorial = Factorial(n);
            Console.WriteLine("Factorial of number {0} is: {1}", n, factorial);
            Console.ReadKey();
        }

        static int Factorial(int factorialToCount)
        {
            int i = 1;
            int result = 1;
            while (i <= factorialToCount) result *= i++;
            return result;
        }
    }
}
