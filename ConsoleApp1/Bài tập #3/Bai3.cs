using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__3
{
    internal class Bai3
    {
        static void trianglecheck()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập cạnh thứ nhất: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập cạnh thứ hai: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập cạnh thứ ba: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("Tam giác đều");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Tam giác cân");
            }
            else
            {
                Console.WriteLine("Tam giác thường");
            }

        }
    }
}