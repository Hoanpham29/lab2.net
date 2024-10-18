using lab2_bai1_btvn.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    public static void Main()
    {
        SinhVienConcrete sinhVien = new SinhVienConcrete("Nguyen Van A", "Cong Nghe Thong Tin", 8.2);
        sinhVien.Xuat();
    }
}