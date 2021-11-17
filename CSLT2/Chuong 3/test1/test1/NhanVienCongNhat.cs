using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test1
{
    class NhanVienCongNhat:NhanVien
    {
        private int snc;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap so ngay cong cua nhan vien: ");
            snc = Convert.ToInt32(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So ngay cong cua nhan vien: {0}", snc);
            TinhLuong();
        }
        public override void TinhLuong()
        {
            base.TinhLuong();
            luong = (int)snc * 90000;
        }
    }
}
