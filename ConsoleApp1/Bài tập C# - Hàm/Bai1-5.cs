using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_C____Hàm
{
    internal class Bai1
    {
        static void Mai12241n(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        }

        static int tinhTong(int a, int b)
        {
            return a + b;
        }
        static bool kiemTraSoChan(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int FindMax(int a, int b, int c)

        {
            int max = a;
            if (b > a) max = b;
            if (c > b) max = c;
            return max;
        }
        static int factor(int a)
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
        static string daoNguocChuoi (string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
