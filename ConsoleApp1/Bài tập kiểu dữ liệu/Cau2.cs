using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bài_tập_kiểu_dữ_liệu
{
    internal class Cau2
    { private static void Meow(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            double chieucao = 0;
            double cannang = 0;
            Console.WriteLine("Nhập chiều cao của bạn (m)");
            while (!double.TryParse(Console.ReadLine(), out chieucao) || chieucao < 0) 
            Console.WriteLine("Lỗi! Nhập lại");
            Console.WriteLine("Nhập cân nặng của bạn (kg)");
            while (!double.TryParse(Console.ReadLine(), out cannang) || cannang < 0)
                Console.WriteLine("Lỗi!Nhập lại");
            double bmi = cannang / Math.Pow(chieucao, 2);
            string phanloai = "";
            if (bmi < 18.5)
                phanloai = "Gầy";
            else if (bmi < 23)
                phanloai = "Bạn ngon lắm";
            else if (bmi < 25)
                phanloai = "Béo";
            else
                phanloai = "Nin";
            double cannangmin = 18.5 * Math.Pow (chieucao, 2);
            double cannangmax = 22.9 * Math.Pow(chieucao, 2);
            Console.WriteLine($"BMI của bạn là: {bmi:F2}" );
            Console.WriteLine($"Phân loại sức khỏe của bạn là: {phanloai}");
            Console.WriteLine($"Cân nặng lý tưởng của bạn nên là từ {cannangmin:F2} đến {cannangmax:F2}");



        }
    }
}
