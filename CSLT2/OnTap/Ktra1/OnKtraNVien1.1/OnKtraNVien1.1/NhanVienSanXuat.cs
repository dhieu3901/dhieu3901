using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnKtraNVien1._1
{
    class NhanVienSanXuat:NhanVien
    {
        private int sosp;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap so san pham cua nhan vien: ");
            sosp = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("\tSo san pham cua nhan vien: {0}", sosp);
            tinhluong();
        }
        public override void tinhluong()
        {
            luong = sosp * 30000;
            base.tinhluong();
        }
    }
}
