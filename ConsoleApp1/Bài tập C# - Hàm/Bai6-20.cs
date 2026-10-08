using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_C____Hàm
{
    internal class Bai6_20
    {
        static void Máain(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        }
        static bool kiemTraSoNguyenTo(int a)
        {
            if (a < 2)
            {
                return false;
            }
            if (a % a == 0 && a % 1 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int DemNguyenAm(string s)
        {
            int count = 0;

            string vowels = "aeiouAEIOU";

            foreach (char c in s)
            {

                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
        static double TinhLuyThua(double x, int y)
        {
            double result = 1;

   
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }

            return result;
        }
        static double CelsiusToFahrenheit(double c)
        {
            return c * 1.8 + 32;
        }
        static int TongCacChuSo(int n)
        {
            int sum = 0;
            n = Math.Abs(n); 
            while (n > 0)
            {
                sum += n % 10; 
                n /= 10;       
            }

            return sum;
        }
        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;  
            }

            return a;
        }
        static double CalculateAverage(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }
    }
}

