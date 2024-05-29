using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix #1");
            PrintResult(RandomGenerationMatrix());
            Console.WriteLine("Matrix #2");
            PrintResult(RandomGenerationMatrix());
            Console.WriteLine("Matrix #3");
            PrintResult(RandomGenerationMatrix());
        }
        static void PrintResult(int[,] matrix)
        {
            try
            {
                replaceZero(matrix);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception!", e.Message);
            }
        }
        public static int[,] RandomGenerationMatrix()
        {
            int[,] result_matrix = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < result_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result_matrix.GetLength(1); j++)
                {
                    result_matrix[i, j] = rnd.Next(10);
                   
                }
            }
            return result_matrix;
        }

        public static void replaceZero(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                    if (i == j || i < j)
                        matrix[i, j] = 0;
                    Console.Write($"{matrix[i, j]}\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}