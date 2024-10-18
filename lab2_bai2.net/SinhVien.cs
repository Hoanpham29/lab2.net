using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_bai2.net
{
    class SinhVien : Nguoi
    {
        private string ma;
        private string hoten;
        private string quequan;
        private int khoa;
        Encoding utf8 = Encoding.UTF8;
        public SinhVien()
        {
        }
        public SinhVien(string ma, string hoten, string quequan, int
        khoa)
        {
            ma = this.utf8.GetString(utf8.GetBytes(ma));
            hoten = this.utf8.GetString(utf8.GetBytes(hoten));
            quequan = this.utf8.GetString(utf8.GetBytes(quequan));
            this.ma = ma;
            this.hoten = hoten;
            this.quequan = quequan;
            this.khoa = khoa;
        }
        public string Ma
        {
            get { return this.ma; }
            set { this.ma = value; }
        }
        public string HoTen
        {
            get { return this.hoten; }
            set { this.hoten = value; }
        }
        public string QueQuan
        {
            get { return this.quequan; }
            set { this.quequan = value; }
        }
        public int Khoa
        {
            get { return this.khoa; }
            set { this.khoa = value; }
        }
        public void TrangThai()
        {
            Console.Write("Trạng thái: ");
            if (this.khoa < 11)
            {
                Console.WriteLine("Đã Tốt Nghiệp");
            }
            else
            {
                Console.WriteLine("Đang Theo Học");
            }
        }
        public void HienThi()
        {
            Console.WriteLine("Mã Sinh Viên: " + this.ma);
            Console.WriteLine("Họ và Tên: " + this.hoten);
            Console.WriteLine("Quê Quán: " + this.quequan);
            Console.WriteLine("Khóa:" + Convert.ToString(this.khoa));
            TrangThai();
        }
    }
}
