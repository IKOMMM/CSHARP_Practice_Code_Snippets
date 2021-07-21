using System;

namespace _TABLE__02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,,] tab = new int[5, 6, 7, 8];
            Random rnd = new Random();
            for (int i = 0; i < tab.GetLength(0); ++i)
            {
                for (int j = 0; j < tab.GetLength(1); ++j)
                    for (int k = 0; k < tab.GetLength(2); ++k)
                        for (int l = 0; l < tab.GetLength(3); ++l)
                        {
                            tab[i, j, k, l] = rnd.Next(1, 100);
                        }                                       
            }
            Print4D(tab, 10);
            Console.ReadKey();
        }
        static void Print4D(int[,,,] tabl, int n)
        {
            // Deklaracje i definicje
            Random rand = new Random();
            int whichNumber = 0;
            int i, j, k, l;
            // Petla

            while (whichNumber < n)
            {
                // Wygeneruj losowe wspolrzedne [i, j, k, l]
                i = rand.Next(0, tabl.GetLength(0));
                j = rand.Next(0, tabl.GetLength(1));
                k = rand.Next(0, tabl.GetLength(2));
                l = rand.Next(0, tabl.GetLength(3));
                // Wydrukuj element o wspolrzednych [i, j, k, l]
                Console.Write("Random element {0}: ", ++whichNumber);
                Console.Write("Table[{0},{1},{2},{3}] = {4}", i, j, k, l, tabl[i, j, k, l]);
                Console.WriteLine();
            }
        }
    }
}
