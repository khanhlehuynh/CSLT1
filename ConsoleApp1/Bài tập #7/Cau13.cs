using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__7
{
    internal class Cau13
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi gốc: ");
            string str = Console.ReadLine();

            Console.Write("Nhập chuỗi cần tìm: ");
            string target = Console.ReadLine();

            Console.Write("Nhập chuỗi cần chèn vào trước: ");
            string insertStr = Console.ReadLine();

            int pos = -1;

            if (target.Length > 0 && target.Length <= str.Length)
            {
                for (int i = 0; i <= str.Length - target.Length; i++)
                {
                    bool match = true;
                    for (int j = 0; j < target.Length; j++)
                    {
                        if (str[i + j] != target[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        pos = i;
                        break;
                    }
                }
            }

            string result = "";

            if (pos != -1)
            {
                for (int i = 0; i < pos; i++)
                {
                    result += str[i];
                }

                result += insertStr;

                for (int i = pos; i < str.Length; i++)
                {
                    result += str[i];
                }
            }
            else
            {
                result = str;
            }

            Console.WriteLine($"Kết quả: {result}");
        }
    }
}
