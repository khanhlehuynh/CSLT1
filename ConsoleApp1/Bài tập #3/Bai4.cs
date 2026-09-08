using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập__3
{
    internal class Bai4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;



            Console.Write("Nhập tọa độ X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhập tọa độ Y: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"\nĐiểm ({x},{y}) nằm ở Góc phần tư thứ I.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"\nĐiểm ({x},{y}) nằm ở Góc phần tư thứ II.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"\nĐiểm ({x},{y}) nằm ở Góc phần tư thứ III.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"\nĐiểm ({x},{y}) nằm ở Góc phần tư thứ IV.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"\nĐiểm ({x},{y}) nằm ngay Gốc tọa độ (0,0).");
            }
            else
            {
                Console.WriteLine($"\nĐiểm ({x},{y}) nằm trực tiếp trên Trục tọa độ.");
            }
        }
    }
}
