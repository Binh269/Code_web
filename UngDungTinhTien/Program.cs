using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVienTinhTien;


namespace UngDungTinhTien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null , b = null;
            double Gio = 0;
            var loaimay = LoaiMay.Vip;
            bool count = true;
            bool DieuHoa = false;
            while (count)
            {
                if (a != 1 && a != 2)
                {
                    Console.WriteLine("Vui long chon loa may !");
                    Console.WriteLine("\t May thuong (10k/h) => Bam phim 1");
                    Console.WriteLine("\t May Vip (20k/h) => Bam phim 2");
                    Console.Write("\t\t Lua chon cua ban la :"); a = int.Parse(Console.ReadLine());
                    if (a == 1)
                    {
                        loaimay = LoaiMay.Thuong;
                    }
                    else if (a == 2)
                    {
                        loaimay = LoaiMay.Vip;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (b != 1 && b != 2)
                {
                    Console.WriteLine("Ban co su dung phong dieu hoa khong ?");
                    Console.WriteLine("\t Co => Bam phim 1");
                    Console.WriteLine("\t Khong => Bam phim 2"); 
                    Console.Write("\t\t Lua chon cua ban la :"); b = int.Parse(Console.ReadLine());
                    if (b == 1)
                    {
                        DieuHoa = true;
                    }
                    else if (b == 2)
                    {
                        DieuHoa = false;
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.Write("Ban choi trong bao lau (gio) :"); string input = Console.ReadLine();
                if (double.TryParse(input, out Gio) && Gio > 0)
                {
                    count = false;
                }
                else
                {
                    continue;
                }
            }
            double tongTien = TinhTien.TinhTongTien(loaimay, Gio, DieuHoa);
            Console.WriteLine($"\t Tong tien phai tra la: {tongTien} VND");
            Console.ReadLine();
        }
    }
}
