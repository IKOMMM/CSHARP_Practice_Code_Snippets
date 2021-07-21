using System;

namespace _Table__01
{
    /* Task:
     * Create a 2-dimensional array with the size of 4x3 and populate it with whatever values you want.
     * Then print the contents of the whiteboard on the screen keeping the layout of the whiteboard (therefore 4
     * rows, 3 columns). Additionally, at the end of the count and print the totals on the screen individual lines. 
     * 
     * Tasks expansion:
     * Adds subtraction, multiplication, division.
     */


    class Program
    {
        static void Main(string[] args)
        {
            //Table
            int[,] tab =
            {
                {1, 5, 6 },
                {7, 9, 4 },
                {2, 1, 0 },
                {6, 0, 3 },
            };

            //Printing
            Console.WriteLine("Print Table:");
            for (int i = 0; i < tab.GetLength(0); ++i)
            {
                for(int j = 0; j <tab.GetLength(1); ++j)
                {
                    Console.Write("{0}", tab[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Maths 
            for (int i = 0; i<tab.GetLength(0); ++i)
            {
                int lineSum = 0;
                int lineDif = 0;
                int linePro = 0;
                int lineQuo = 0;
                for (int j = 0; j < tab.GetLength(1); ++j)
                {
                    lineSum += tab[i, j];
                    //Extantion
                    lineDif -= tab[i, j];
                    linePro *= tab[i, j];
                    if (tab.GetLength(1) == 0 || lineQuo == 0)
                    {
                        ++j;
                    }
                    else
                    {
                        lineQuo /= tab[i, j];
                    }                    
                }

            Console.WriteLine("Line Sum {0}: {1}", i, lineSum);
            Console.WriteLine("Line Difference {0}: {1}", i, lineSum);
            Console.WriteLine("Line Product {0}: {1}", i, lineSum);
            Console.WriteLine("Line Quotient {0}: {1}", i, lineSum);
            Console.WriteLine();
            }
            Console.ReadKey();//Compilation Break Line
        }
    }
}
