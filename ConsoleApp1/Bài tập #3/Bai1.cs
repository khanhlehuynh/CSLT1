using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__3
{
    internal class Bai1
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Enter an integer: ");
            int number;

            
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input! Please enter a valid integer: ");
            }

          
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even integer (Số chẵn).");
            }
            else
            {
                Console.WriteLine($"{number} is an odd integer (Số lẻ).");
            }
        }
    }
}