using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__7
{
    internal class Cau2
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập vào một chuỗi: ");
            string input = Console.ReadLine();

            int length = 0;

            // Duyệt từng ký tự trong chuỗi để đếm
            foreach (char c in input)
            {
                length++;
            }

            Console.WriteLine($"Độ dài của chuỗi là: {length}");
        }
    }
}
