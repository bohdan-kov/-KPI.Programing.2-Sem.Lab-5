using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_5_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix #1");
            Random rnd = new Random();
            PrintResult(RandomGenerationMatrix(rnd));
        }

        static void PrintResult(int[,] matrix)
        {
            try
            {
                minElement(matrix);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception!", e.Message);
            }
        }

        public static int[,] RandomGenerationMatrix(Random rnd)
        {
            int[,] result_matrix = new int[5, 5];
            for (int i = 0; i < result_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result_matrix.GetLength(1); j++)
                {
                    result_matrix[i, j] = rnd.Next(10);

                }
            }
            return result_matrix;
        }

        public static int[,] transponentMatrix(int[,] matrix)
        {
            int tmp_num;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < matrix.GetLength(1); j++)
                {
                    tmp_num = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = tmp_num;
                }
            }
            return matrix;
        }

        public static void minElement(int[,] matrix)
        {


            matrix = transponentMatrix(matrix);


            int sumModElem;
            int sumModPrewElem = 0;
            int resultElem = matrix[0,0];
            int minElemColums = matrix[0,0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumModElem = 0;
                minElemColums = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (minElemColums > matrix[i, j])
                        minElemColums = matrix[i, j];
                    sumModElem += Math.Abs(matrix[i, j]);
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.Write(sumModElem);
                Console.WriteLine();
                if (sumModElem > sumModPrewElem)
                {
                    sumModPrewElem = sumModElem;
                    resultElem = minElemColums;
                }
            }
            Console.WriteLine();
        Console.WriteLine(resultElem);
        }
    }
}
