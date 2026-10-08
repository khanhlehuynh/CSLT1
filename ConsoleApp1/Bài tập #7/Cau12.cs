using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__7
{
    internal class Cau12
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi gốc: ");
            string str = Console.ReadLine();

            Console.Write("Nhập chuỗi con cần đếm: ");
            string sub = Console.ReadLine();

            int count = 0;

            if (sub.Length > 0 && sub.Length <= str.Length)
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
                        count++;
                        i += sub.Length - 1;
                    }
                }
            }

            Console.WriteLine($"Số lần xuất hiện của '{sub}' là: {count}");
        }
    }
}
