using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    internal class Session5
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            numbertriangle();
        }
        static void bangnhan15()
        {
            int i = 0;
            for (i = 2; i <= 15; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }




        }
        static void tamgiadausao()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int i = 0;
            string sao = "";
            for (i = 1; i <= 15; i++)
            {
                sao += "* ";
                Console.WriteLine(sao);
            }

        }
        static void numberguessinggame()
        {
            Random rnd = new Random();
            int com_num = rnd.Next(30) + 1;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(com_num);









        }
        // Writr a program to check whetherr a triangle is Equilateral, Isosceles or Scalene.
        static void trianglecheck()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập cạnh thứ nhất: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập cạnh thứ hai: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập cạnh thứ ba: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("Tam giác đều");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Tam giác cân");
            }
            else
            {
                Console.WriteLine("Tam giác thường");
            }


        }
        // Write a program to read 1o numbers and find their average and sum 
        static void averageandsum()
        {
            double sum = 0;
            int totalnumbers = 10;
            for (int i = 0; i < totalnumbers; i++)
            {
                double number;
                Console.WriteLine($"Nhap so thu {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Vui lòng nhập một số hợp lệ.");
                }
                sum += number;
            }
            double average = sum / totalnumbers;
            Console.WriteLine($"Tổng: {sum}");
            Console.WriteLine($"Trung bình: {average}");
        }
        // Write a program to display a pattern like a number triangle.
        static void numbertriangle()

        {
            int n = 5;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                { Console.Write(j); }
                Console.WriteLine();
            }
            int count = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }
            int count1 = 1;
            for (int i = 1; i < n; i++)
            { for (int space = 1; space <= n - i; space++)
                { Console.Write(" "); }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count1 + " ");
                    count1++;
                }
                Console.WriteLine();                      
                        
                        
                        
             }
    







        } 
      
        
       
    }
            
    }


