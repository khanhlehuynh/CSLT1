using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bai_tap__6
{
    internal class Cau3
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số hàng N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Nhập số cột M: ");
            int M = int.Parse(Console.ReadLine());

            int[,] matrix = CreateRandomMatrix(N, M, 1, 99);

         
            PrintMatrix(matrix);

            Console.Write($"\nNhập chỉ số hàng i cần in (0 đến {N - 1}): ");
            int rowI = int.Parse(Console.ReadLine());
            PrintRow(matrix, rowI);

            Console.Write($"Nhập chỉ số cột i cần in (0 đến {M - 1}): ");
            int colI = int.Parse(Console.ReadLine());
            PrintCol(matrix, colI);

            int maxVal = FindMax(matrix);
            Console.WriteLine($"\nGiá trị lớn nhất của ma trận: {maxVal}");

            int minRow = FindMinOfRow(matrix, rowI);
            Console.WriteLine($"Giá trị nhỏ nhất của hàng {rowI}: {minRow}");

            int minCol = FindMinOfCol(matrix, colI);
            Console.WriteLine($"Giá trị nhỏ nhất của cột {colI}: {minCol}");

            Console.WriteLine("\n--- MA TRẬN CHUYỂN VỊ (TRANSPOSE) ---");
            int[,] transposed = TransposeMatrix(matrix);
            PrintMatrix(transposed);

            Console.WriteLine("\n--- CÁC ĐƯỜNG CHÉO (NẾU LÀ MA TRẬN VUÔNG) ---");
            PrintDiagonals(matrix);

            Console.ReadKey();
        }

        static int[,] CreateRandomMatrix(int rows, int cols, int min, int max)
        {
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(min, max + 1);
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        static void PrintRow(int[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            if (rowIndex < 0 || rowIndex >= matrix.GetLength(0))
            {
                Console.WriteLine("Chỉ số hàng không hợp lệ!");
                return;
            }

            Console.Write($"Hàng {rowIndex}: ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[rowIndex, j] + " ");
            }
            Console.WriteLine();
        }

        static void PrintCol(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            if (colIndex < 0 || colIndex >= matrix.GetLength(1))
            {
                Console.WriteLine("Chỉ số cột không hợp lệ!");
                return;
            }

            Console.Write($"Cột {colIndex}: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(matrix[i, colIndex] + " ");
            }
            Console.WriteLine();
        }

        static int FindMax(int[,] matrix)
        {
            int max = matrix[0, 0];
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }

        static int FindMinOfRow(int[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            int min = matrix[rowIndex, 0];

            for (int j = 1; j < cols; j++)
            {
                if (matrix[rowIndex, j] < min)
                {
                    min = matrix[rowIndex, j];
                }
            }
            return min;
        }

        static int FindMinOfCol(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            int min = matrix[0, colIndex];

            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, colIndex] < min)
                {
                    min = matrix[i, colIndex];
                }
            }
            return min;
        }

        static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }

        static void PrintDiagonals(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                Console.WriteLine("Ma trận không phải ma trận vuông, không có đường chéo chính/phụ.");
                return;
            }

            Console.Write("Đường chéo chính (Main diagonal): ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();

            Console.Write("Đường chéo phụ (Secondary diagonal): ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(matrix[i, rows - 1 - i] + " ");
            }
            Console.WriteLine();
        }
    }
}