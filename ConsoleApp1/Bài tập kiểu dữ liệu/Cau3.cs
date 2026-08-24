using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ConsoleApp1.Bài_tập_kiểu_dữ_liệu

    
{  
    enum CurrencyType
    {  USD = 1,
       EUR = 2,
       JPY = 3,
       GBR = 4
    }
   
    internal class Cau3
       
    {
        private static void Meoww(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            decimal tienVND = 0;
            Console.WriteLine("Nhập số tiền bạn muốn đổi (VND):");
            while (!decimal.TryParse (Console.ReadLine(), out tienVND) || tienVND <0 )
            Console.WriteLine("Lỗi!");
            Console.WriteLine("Chọn loại ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBR)");
            int luachon = 0;
            while (!int.TryParse(Console.ReadLine(), out luachon) || luachon < 1 || luachon > 4)
                Console.WriteLine("Lỗi!");
            CurrencyType loaitien = (CurrencyType)luachon;
            decimal phidichvu = 0.05m * tienVND;
            decimal tientinhdoi = tienVND - phidichvu;

            decimal tygia = 0m;
            string tentien = "";
            switch (loaitien)
            {
                case CurrencyType.USD:
                    tygia = 25400m;
                    tentien = "USD";
                    break;
                case CurrencyType.EUR:
                    tygia = 27000m;
                    tentien = "EUR";
                    break;
                case CurrencyType.JPY:
                    tygia = 165m;
                    tentien = "JPY";
                    break;
                case CurrencyType.GBR:
                    tygia = 32100m;
                    tentien = "GBR";
                    break;
            }        

                    decimal tienngoaite = tientinhdoi / tygia;

                    Console.WriteLine($"Phí dịch vụ (0,5%):{phidichvu:N0} VND ");
                    Console.WriteLine($"Số tiền VND tính đổi: {tientinhdoi:N0} VND");
                    Console.WriteLine($"Số tiền quy đổi:{tienngoaite:N2} {tentien}");

            

                    








            
                














        }
       
    }
}
