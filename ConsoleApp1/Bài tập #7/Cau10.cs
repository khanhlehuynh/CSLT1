using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__7
{
    internal class Cau10
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi gốc: ");
            string str = Console.ReadLine();

            Console.Write("Nhập chuỗi con cần tìm vị trí: ");
            string sub = Console.ReadLine();

            int position = -1;

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
                        position = i;
                        break;
                    }
                }
            }

            if (position != -1)
            {
                Console.WriteLine($"Tìm thấy chuỗi '{sub}' tại vị trí index: {position}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy chuỗi '{sub}' trong chuỗi gốc.");
            }
        }
    }
}
