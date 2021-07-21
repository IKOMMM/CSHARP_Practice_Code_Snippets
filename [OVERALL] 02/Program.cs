using System;

namespace _OVERALL__02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string aString;
                int a;
                string bString;
                int b;

                //EnterSection
                Console.WriteLine("Enter First:");
                aString = Console.ReadLine();
                Console.WriteLine("Enter Second:");
                bString = Console.ReadLine();
                int.TryParse(aString, out a);
                int.TryParse(bString, out b);
                Console.WriteLine("Division result: {0}", a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by 0");
            }

            Console.ReadKey();
        }
    }
}
