using System;

namespace _OVERALL__01
{
    class Program
    {
        static void Main(string[] args)
        {
            string aString;
            int a;
            string bString;
            int b;

            //EnterSection
            Console.WriteLine("Enter First:");
            aString = Console.ReadLine();            
            int.TryParse(aString, out a);

            Console.WriteLine("Enter Second:");
            bString = Console.ReadLine();            
            int.TryParse(bString, out b);

            //ResultSection - Before
            Console.WriteLine("Numbers before changes: a = {0}, b = {1}", a, b);
            //ResultSection - After
            Interchange(ref a, ref b);
            Console.WriteLine("Numbers after changes: a = {0}, b = {1}", a, b);
            Console.ReadKey();
        }

        static void Interchange(ref int aa, ref int bb)
        {
            int tmp = aa;
            aa = bb;
            bb = tmp;
        }
    }
}
