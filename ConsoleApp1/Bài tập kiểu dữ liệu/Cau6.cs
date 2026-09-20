using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_kiểu_dữ_liệu
{
    internal class Cau6
    {
        static void Main23(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a;
            Console.WriteLine("Nhap so nguyen A");
            a = int.Parse(Console.ReadLine());
            if (a%2==0)
            {
                Console.WriteLine("A la so chan");
            }
            else
            {
                Console.WriteLine("A la so le");
            }



        }
    }
}
