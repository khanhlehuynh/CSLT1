using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__7
{
    internal class Cau8
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập vào một chuỗi: ");
            string input = Console.ReadLine();

            int vowels = 0;
            int consonants = 0;

            foreach (char ch in input)
            {
                char c = char.ToLower(ch);

                if (c >= 'a' && c <= 'z')
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine($"Số nguyên âm: {vowels}");
            Console.WriteLine($"Số phụ âm: {consonants}");
        }
    }
}
