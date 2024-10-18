using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_bai1_btvn.net
{
    public class SinhVienConcrete : SinhVienUneti
    {
        private double Diem { get; set; }

        public SinhVienConcrete(string hoTen, string nganh, double diem)
        {
            HoTen = hoTen;
            Nganh = nganh;
            Diem = diem;
        }

        public override double GetDiem()
        {
            return Diem;
        }
    }

}
