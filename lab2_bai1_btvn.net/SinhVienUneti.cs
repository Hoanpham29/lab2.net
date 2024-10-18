using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class SinhVienUneti
{
    public string HoTen { get; set; }
    public string Nganh { get; set; }

    public abstract double GetDiem();

    public string GetXepLoaiHL()
    {
        double diem = GetDiem();
        if (diem >= 8.5) return "Gioi";
        if (diem >= 7.0) return "Kha";
        if (diem >= 5.5) return "Trung Binh";
        return "Yeu";
    }

    public void Xuat()
    {
        Console.WriteLine($"Ho Ten: {HoTen}");
        Console.WriteLine($"Nganh: {Nganh}");
        Console.WriteLine($"Diem: {GetDiem()}");
        Console.WriteLine($"Xep Loai Hoc Luc: {GetXepLoaiHL()}");
    }
}

