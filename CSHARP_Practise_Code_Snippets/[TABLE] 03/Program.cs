using System;

namespace _TABLE__03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize an array containing four Int arrays
            int[][] tab = new int[10][];
            Random rnd = new Random();
            for (int i = 0; i < tab.Length; ++i)
            {
                tab[i] = new int[1 + 2 * i];
                for (int j = 0; j < tab[i].Length; ++j)
                    tab[i][j] = rnd.Next(0, 10);
            }

            //Printing
            for (int i = 0; i < tab.Length; ++i)
            {
                for (int j = 0; j < tab[i].Length; ++j)
                {
                    Console.Write("{0} ", tab[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
