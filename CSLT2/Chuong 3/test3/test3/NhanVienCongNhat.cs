using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test3
{
    class NhanVienCongNhat:NhanVien
    {
        private float snc;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap so ngay cong cua nhan vien: ");
            snc = float.Parse(Console.ReadLine());
        }
        public override void tinhluong()
        {
            luong = snc * 90000;
            base.tinhluong();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So ngay cong cua nhan vien la: ");
            tinhluong();
        }
    }
}
