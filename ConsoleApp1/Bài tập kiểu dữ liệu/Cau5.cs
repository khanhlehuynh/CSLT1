using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1.Bài_tập_kiểu_dữ_liệu
{
    internal class Cau5
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int tccsharp = 4;
            int tctoan = 3;
            int tcanh = 2;
            double diemcsharp = 0;
            double diemtoan = 0;
            double diemanh = 0;
            Console.WriteLine($"Nhập điểm C# ({tccsharp} TC)");
            while (!double.TryParse(Console.ReadLine(), out diemcsharp))
            {
                Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại.");
            }
            Console.WriteLine($"Nhập điểm Toán ({tctoan} TC)");
            while (!double.TryParse(Console.ReadLine(), out diemtoan))
            {
                Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại.");
            }
            Console.WriteLine($"Nhập điểm Anh ({tcanh} TC)");

            

            while (!double.TryParse(Console.ReadLine(), out diemanh))
            
                Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại.");


                string diemchu;
                string xeploai;
                double GPAthang4 = 0;

                int sotinchi = tccsharp + tctoan + tcanh;
                double diemtrungbinh = (diemcsharp * tccsharp + diemtoan * tctoan + diemanh * tcanh) / sotinchi;

                {
                    if (diemtrungbinh >= 8.5)

                    {
                        diemchu = "A";
                        xeploai = "Giỏi";
                        GPAthang4 = 4;


                    }

                    else if (diemtrungbinh >= 7)
                    {
                        diemchu = "B";
                        xeploai = "Khá";
                        GPAthang4 = 3;
                    }
                    else if (diemtrungbinh >= 5.5)
                    {
                        diemchu = "C";
                        xeploai = "Trung bình";
                        GPAthang4 = 2;
                    }
                    else if (diemtrungbinh >= 4)
                    {
                        diemchu = "D";
                        xeploai = "Yếu";
                        GPAthang4 = 1;
                    }
                    else
                    {
                        diemchu = "F";
                        xeploai = "Kém";
                        GPAthang4 = 0;
                    }

                    Console.WriteLine($"Điểm TB thang 10 của mày là: {diemtrungbinh:F2}");
                    Console.WriteLine($"Điểm TB thang 4 của mày là: {GPAthang4:F2}");
                    Console.WriteLine($"Xếp loại: {xeploai}");
                    Console.WriteLine($"Điểm chữ: {diemchu}");
                }

            


        }
    }
}