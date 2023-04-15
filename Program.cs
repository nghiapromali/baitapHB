using System;
using System.Text;

namespace chuyendoihienthiascii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Chương trình nhập ký tự và mã ASCII");
            Console.WriteLine("1. Nhập một ký tự để hiển thị mã ASCII");
            Console.WriteLine("2. Nhập một mã ASCII để hiển thị ký tự (0 đến 127)");
            Console.WriteLine("3. Hiển thị bảng mã ASCII");
            Console.Write("Nhập tuỳ chọn từ 1 đến 3  ");

            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.Write("Nhập ký tự: ");
                    char nhap = Console.ReadLine()[0];
                    int ascii = (int)nhap;
                    Console.WriteLine($"Mã ASCII của ký tự {nhap} là: {ascii}.");
                    break;
                case 2:
                    Console.Write("Nhập một mã ASCII: ");
                    int ma = int.Parse(Console.ReadLine());
                    char kytu = (char)ma;
                    Console.WriteLine($"Ký tự {ma} có mã là {kytu}");
                    break;
                case 3:
                    Console.WriteLine("Hiển thị bảng mã ASCII: ");
                    for (int i = 0; i < 128; i++)
                    {
                        char asciiikytu = (char)i;
                        Console.WriteLine($"Mã {i} : {asciiikytu}");
                    }
                    break;
                default:
                    Console.WriteLine("Vui lòng nhập lại!");
                    break;
            }
        }
    }
}
