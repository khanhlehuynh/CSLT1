using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace ConsoleApp1.Bài_tập_kiểu_dữ_liệu
{
    internal class Cau4
    { private static void Meowww(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            DateTime ngaysinh;
            Console.WriteLine("Nhập ngày sinh của bạn (dd/MM/yyyy)");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, DateTimeStyles.None, out ngaysinh))
            {
                Console.WriteLine("Định dạng ngày sinh không hợp lệ. Vui lòng nhập lại (dd/MM/yyyy)");
            }
            DateTime ngayhomnay = DateTime.Now.Date;
            int tuoi = ngayhomnay.Year - ngaysinh.Year;
            DateTime sinhnhatnamnay = ngaysinh.AddYears(tuoi);
            Console.WriteLine($"Ngay sinh nhat la {sinhnhatnamnay}");

            {
                if (ngayhomnay < sinhnhatnamnay)
                     tuoi--;
            }
            Console.WriteLine($"Tuoi cua ban la: {tuoi}");

            TimeSpan songaydensinhnhatketiep = sinhnhatnamnay - ngayhomnay;
                { if (songaydensinhnhatketiep.TotalDays < 0)
                    {
                        sinhnhatnamnay = sinhnhatnamnay.AddYears(1);
                        songaydensinhnhatketiep = sinhnhatnamnay - ngayhomnay;
                    }
                };


            Console.WriteLine($"so ngay la {songaydensinhnhatketiep.TotalDays} den sinh nhat tiep theo cua ban");








        }
    }
}
