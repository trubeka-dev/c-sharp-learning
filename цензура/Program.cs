using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace цензура
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[][] arr = new int[4][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[rnd.Next(3, 7)];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(1, 100);
                }
            }
            printMatrix(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr[i]);
            }
            Console.WriteLine();
            printMatrix(arr);

            void printMatrix(int[][] m)
            {
                for (int i = 0;i < m.Length; i++)
                {
                    for (int j = 0;j < m[i].Length; j++)
                    {
                        Console.Write($"{m[i][j], 4}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
