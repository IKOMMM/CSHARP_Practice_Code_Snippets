using System;

namespace _OVERALL__04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(-100, 100);
            int b = rnd.Next(-100, 100);

            // EVEN OR ODD
            string evenodddString = (a % 2 == 0 ? "even" : "odd");
            Console.WriteLine("Number {0} is {1}", a, evenodddString);

            // EVEN OR ODD PAIR
            if (a % 2 == 0 && b % 2 == 0)
                Console.WriteLine("{0} and {1} are even", a, b);
            else if (a % 2 != 0 && b % 2 != 0)
                Console.WriteLine("{0} and {1} are odd", a, b);
            else
                Console.WriteLine("One of the number: {0} or {1} is odd", a, b);

            //GREATER THEN 0
            if (a > 0 || b > 0)
                Console.WriteLine("One of the number: {0} or {1} greater then 0", a, b);
            else
                Console.WriteLine("One of the number: {0} or {1} isn't greater then 0", a, b);

            Console.ReadKey();
        }
    }
}
