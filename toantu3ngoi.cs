using System;
using System.Text;

namespace siuuuuuuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai báo kiểu dữ liệu bool, kiểm tra và in ra màn hình *không sử dụng if
            Console.OutputEncoding = Encoding.UTF8; // Mã hoá ký tự đầu ra UTF-8 
            bool traffic_jam = true; //1
            bool traffic_clear = false; //0

            //Toán tử ba ngôi: <biểu thức điều kiện>?<giá trị trả về nếu true> : <giá trị trả về nếu false>
            Console.WriteLine("Giao thông vào giờ cao điểm {0}", traffic_jam ? "tắc nghẽn" : "thông thoáng"); //giá trị trả về của biểu thức là true -> In ra tắc nghẽn
            Console.WriteLine("Giao thông vào sáng sớm {0}", traffic_clear ? "tắc nghẽn" : "thông thoáng"); //giá trị trà về của biểu thức là false -> In ra thông thoáng
        }
    }
}
