using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nums =
            {
                {1, 4, 7, 10 },
                {5, 18, 20, 3 },
                {6, 12, 13, 10 }
            };
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                int rowMax = nums[i, 0];
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] > rowMax)
                    {
                        rowMax = nums[i, j];
                    }
                }
                Console.WriteLine($"Макс число {i} строки - {rowMax}. ");
            }
        }
    }
}
