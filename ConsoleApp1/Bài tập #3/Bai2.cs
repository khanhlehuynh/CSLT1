using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__3
{
    internal class Bai2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

          

            Console.Write("Enter 1st number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter 3rd number: ");
            double num3 = double.Parse(Console.ReadLine());

            double max = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            Console.WriteLine($"\nThe 1st Number is: {num1}");
            Console.WriteLine($"The 2nd Number is: {num2}");
            Console.WriteLine($"The 3rd Number is: {num3}");
            Console.WriteLine($"\nThe largest number among the three is: {max}");
        }


    }
}
