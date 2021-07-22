using System;

namespace _TABLE__04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Height of Pascal's triangle
            int n;
            Console.Write("Enter the height of Pascal's triangle: ");
            string text = Console.ReadLine();
            int.TryParse(text, out n);

            // Array initialization
            int[][] tab = new int[n][];
            for (int i = 0; i < tab.Length; ++i)
            {
                tab[i] = new int[i + 1];
                for (int j = 0; j < tab[i].Length; ++j)
                    if (j == 0 || j == tab[i].Length - 1)
                        tab[i][j] = 1;
                    else
                        tab[i][j] = tab[i - 1][j - 1] + tab[i - 1][j];              
            }

            //Printing
            for(int i = 0; i<tab.Length; ++i)
            {
                for(int j = 0; j < tab[i].Length; ++j)
                {
                    Console.Write("{0} ", tab[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
