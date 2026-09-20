using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    internal class Session6
    {
     static int FindMax( int a, int b, int c)
        
       { int max = a;
            if (b > a) max = b;
            if (c > b) max = c;
            return max; }
        // find max of n numbers

        static int FindMax(int a, params int[] b)
        {
            int max = a;
            foreach (int num in b)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }



        public static void Ma12in(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 0;
            int b = 0; int c = 0; int d = 0;
            // int max = FindMax(a, b, c, d);
            // Console.WriteLine($"Số lớn nhất là: {max}");
            int e = 5;

            Console.WriteLine(factor(e));

        }

       // Write a program to calculate the factorial of a number ( a non-negative integer). The function accepts the number as an arguement

        static int factor ( int a)
        {
            if (a == 0 || a == 1)
            {
                return 1;
            }
            else
            {
                
               return a * factor(a - 1);
               
                

                
            }
        }



    }
}
