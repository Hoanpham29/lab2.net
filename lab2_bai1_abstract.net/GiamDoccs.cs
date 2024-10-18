using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_bai1_abstract.net
{
    class GiamDoc : NhanVien
    {
        public GiamDoc()
        {
            this.className = this.GetType().Name;
        }
        public override string ChucVu()
        {
            return "Giám Đốc";
        }
        public override void CongViec()
        {
            Console.WriteLine("Ban hành quyết định, chỉ ra đường lối chiến lược kinh doanh"); 
        }
    }
}
