using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int num = 1;
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[i+1];
            }
            for (int  i = 0; i < n; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = num++;
                }
            }
            
            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
