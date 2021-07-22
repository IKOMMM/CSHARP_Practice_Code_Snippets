using System;

namespace _TABLE_06_
{
    class Program
    {

        /*TARGET
         * 1 2
         * 3 4 5 6
         * 7 8 9
         */
        static void Main(string[] args)
        {
            int[][] tab =
            {
                new int[] {1,2},
                new int[] {3,4,5,6},
                new int[] {7, 8 ,9}
            };

            int sum = 0;
            for(int i = 0; i < tab.Length; ++i)
            {
                for (int j = 0; j < tab[i].Length; ++j)
                {
                    sum += tab[i][j];
                }

                Console.WriteLine(sum);
                Console.ReadKey();

            }
        }
    }
}
