using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp1.Bài_tập_kiểu_dữ_liệu
{
    internal class Cau1
       
    { private static void Main(string[] args)

            
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            decimal socu = 0;
            decimal somoi = 0;
            Console.WriteLine("Nhập chỉ số điện cũ (kwh)");
            while (!decimal.TryParse(Console.ReadLine(), out socu) || socu < 0) 
            Console.WriteLine("Lỗi! Vui lòng nhập lại");
            Console.WriteLine("Nhập chỉ số điện mới (kwh)");
            while (!decimal.TryParse(Console.ReadLine(), out somoi) || somoi < socu) 
            Console.WriteLine("Chỉ số điện mới phải lớn hơn chỉ số điện cũ. Xin vui lòng nhập lại!");
            decimal sodien = somoi - socu;
            decimal tienchuathue = 0;
            if (sodien <= 50)
                tienchuathue = 50 * 1806m;
            else if (sodien <= 100)
                tienchuathue = 50 * 1806m + (sodien - 50) * 1866m;
            else if (sodien <= 200)
                tienchuathue = 50 * 1806m + 50 * 1866m + (sodien - 100) * 2667m;
            else if (sodien <= 300)
                tienchuathue = 50 * 1806m + 50 * 1866m + 100 * 2167m + (sodien - 200) * 2729m;
            else
                tienchuathue = 50 * 1806m + 50 * 1866m + 100 * 2167m + 100 * 2729m + (sodien - 300) * 3050m;
            decimal thueVAT = tienchuathue * 0.08m;
            decimal tongtien = tienchuathue + thueVAT;
            Console.WriteLine("HÓA ĐƠN TIỀN ĐIỆN");
            Console.WriteLine($"Số điện tiêu thụ là: {sodien} kWh");
            Console.WriteLine($"Tiền điện chưa thuế là: {tienchuathue:N0} VND");
            Console.WriteLine($"Thuế VAT là: {thueVAT:N0} VND");
            Console.WriteLine($"Tổng thanh toán là: {Math.Round (tongtien):N0}");
            
            


            {

            }
        }
    }
}
