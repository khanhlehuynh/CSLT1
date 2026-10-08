using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__7
{
    internal class Cau6
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi thứ nhất: ");
            string str1 = Console.ReadLine();

            Console.Write("Nhập chuỗi thứ hai: ");
            string str2 = Console.ReadLine();

            int len1 = 0;
            foreach (char c in str1) len1++;

            int len2 = 0;
            foreach (char c in str2) len2++;

            bool isEqual = true;

            if (len1 != len2)
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < len1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }

            if (isEqual)
            {
                Console.WriteLine("Hai chuỗi bằng nhay.");
            }
            else
            {
                Console.WriteLine("Hai chuỗi không bằng nhau.");
            }
        }
    }
}
