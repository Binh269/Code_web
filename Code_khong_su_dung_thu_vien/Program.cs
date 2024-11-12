using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_khong_su_dung_thu_vien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null, b = null;
            double Gio = 0, loaimay = 0, DieuHoa = 0;
            bool count = true;
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
                        loaimay = 15000;
                    }
                    else if (a == 2)
                    {
                        loaimay = 20000;
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
                        DieuHoa = 5000;
                    }
                    else if (b == 2)
                    {
                        DieuHoa = 0;
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
            double tongTien = (loaimay+DieuHoa)*Gio;
            Console.WriteLine($"\t Tong tien phai tra la: {tongTien} VND");
            Console.ReadLine();
        }
    }
}
