using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__7
{
    internal class Cau7
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập vào một chuỗi: ");
            string input = Console.ReadLine();

            int alphabets = 0;
            int digits = 0;
            int specialChars = 0;

            foreach (char c in input)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    alphabets++;
                }
                else if (c >= '0' && c <= '9')
                {
                    digits++;
                }
                else
                {
                    specialChars++;
                }
            }

            Console.WriteLine($"Số chữ cái: {alphabets}");
            Console.WriteLine($"Số chữ số: {digits}");
            Console.WriteLine($"Số ký tự đặc biệt: {specialChars}");
        }
    }
}
