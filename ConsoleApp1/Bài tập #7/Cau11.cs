using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__7
{
    internal class Cau11
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập vào một ký tự: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine($"'{c}' là chữ cái (Chữ thường / Lowercase).");
            }
            else if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine($"'{c}' là chữ cái (Chữ hoa / Uppercase).");
            }
            else
            {
                Console.WriteLine($"'{c}' KHÔNG PHẢI là chữ cái.");
            }
        }
    }
}
