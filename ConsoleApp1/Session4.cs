using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp1
{
    internal class Session4
    { static void Main(string[] args)
        { // 1. Nhập vào 2 số nguyên x, y. Tính tổng, hiệu, tích, thương của 2 số đó.
            Console.OutputEncoding = Encoding.UTF8;


            // 2.  Display a table of values for the function a = b^2 + 2b + 1, where b runs from -5 to 5.
            Console.WriteLine("b\t a = b^2 + 2b + 1");



            for (int b = -5; b <= 5; b++)
            {
                int a = b * b + 2 * b + 1;
                Console.WriteLine($"{b}\t {a}");


            }
            {   // 3. Take as input the distance in kilometers and the time taken in hours, minutes, and seconds. Calculate the average speed in kilometers per hour and miles per hour.
                Console.WriteLine("Nhap khoang cach (km)");
                double distance = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gio (h)");
                double hours = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap phut (min)");
                double minutes = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap giay (s)");
                double seconds = double.Parse(Console.ReadLine());
                double sumtime = hours + minutes / 60 + seconds / 3600;
                double speed = distance / sumtime;
                Console.WriteLine($"Van toc trung binh la: {speed} km/h");
                double mile = distance * 0.621371;
                double speedMile = mile / sumtime;
                Console.WriteLine($"Van toc trung binh la: {speedMile} mile/h");


                // 4. Giải phương trình bậc 2
                Console.WriteLine("Nhập hệ số a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập hệ số b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập hệ số c");
                double c = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("Phương trình vô số nghiệm");
                        }
                        else
                        {
                            Console.WriteLine("Phương trình vô nghiệm");
                        }
                    }
                    else
                    {
                        double x = -c / b;
                        Console.WriteLine($"Phương trình có một nghiệm: x = {x}");
                    }
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        Console.WriteLine("Phương trình vô nghiệm");
                    }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        Console.WriteLine($"Phương trình có một nghiệm kép: x = {x}");
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
                    }
                }






            }
        }
    }
}
