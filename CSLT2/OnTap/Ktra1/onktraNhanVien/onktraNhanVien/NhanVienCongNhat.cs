using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktraNhanVien
{
    class NhanVienCongNhat:NhanVien
    {
        protected int sonc;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap so ngay cong: ");
            sonc = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So ngay cong: {0}", sonc);
            tinhluong();
        }
        public override void tinhluong()
        {
            luong = sonc * 90000;
            base.tinhluong();
        }
    }
}
