using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_bai1_abstract.net
{
    class KeToan : NhanVien
    {
        public KeToan()
        {
            this.className = this.GetType().Name;
        }
        public override string ChucVu()
        {
            return "Kế Toán";
        }
        public override void CongViec()
        {
            Console.WriteLine("Kiểm kê ngân sách, chi thu");
        }
    }
}
