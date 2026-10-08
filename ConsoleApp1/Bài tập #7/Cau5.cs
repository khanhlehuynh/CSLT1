using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__7
{
    internal class Cau5
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập vào một chuỗi: ");
            string input = Console.ReadLine();


            string[] words = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            Console.WriteLine($"Tổng số từ trong chuỗi là: {wordCount}");
        }
    }
}
