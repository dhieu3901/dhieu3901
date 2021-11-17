using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnKtraNVien1._1
{
    class NhanVienCongNhat:NhanVien
    {
        private int sonc;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap so ngay cong cua nhan vien: ");
            sonc = Convert.ToInt32(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("\tSo ngay cong cua nhan vien: {0}", sonc);
            tinhluong();
        }
        public override void tinhluong()
        {
            luong = sonc * 90000;
            base.tinhluong();
        }
    }
}
