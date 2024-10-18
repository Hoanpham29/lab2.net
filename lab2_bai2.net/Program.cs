using lab2_bai2.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        SinhVien sv3 = new SinhVien();
        sv3.Ma = "115";
        sv3.HoTen = "Lê Thị Thanh Trà";
        sv3.QueQuan = "Hà Nam";
        sv3.Khoa = 8;
        sv3.HienThi();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Sử dụng phương thức của interface cho ra kết quả"); 
        Nguoi ng = sv3;
        ng.HienThi();
        Console.ReadKey();
    }
}