using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test2
{
    class NhanVienCongNhat:NhanVien
    {
        private int snc;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap so ngay cong cua nhan vien: ");
            snc = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So ngay cong cua nhan vien la: {0}", snc);
            tinhluong();
        }
        public override void tinhluong()
        {
            luong = snc * 90000;
            base.tinhluong();
        }
    }
}
