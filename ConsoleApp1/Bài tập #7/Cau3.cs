using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__7
{
    internal class Cau3
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập vào một chuỗi: ");
            string input = Console.ReadLine();

            Console.Write("Các ký tự trong chuỗi là: ");

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
