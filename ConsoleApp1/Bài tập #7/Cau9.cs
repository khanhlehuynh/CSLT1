using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__7
{
    internal class Cau9
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi gốc: ");
            string str = Console.ReadLine();

            Console.Write("Nhập chuỗi con cần tìm: ");
            string sub = Console.ReadLine();

            bool found = false;

            if (sub.Length <= str.Length)
            {
                for (int i = 0; i <= str.Length - sub.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < sub.Length; j++)
                    {
                        if (str[i + j] != sub[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                Console.WriteLine($"Chuỗi '{sub}' CÓ xuất hiện trong chuỗi gốc.");
            }
            else
            {
                Console.WriteLine($"Chuỗi '{sub}' KHÔNG xuất hiện trong chuỗi gốc.");
            }
        }
    }
}