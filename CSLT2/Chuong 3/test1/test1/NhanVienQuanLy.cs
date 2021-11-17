using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test1
{
    class NhanVienQuanLy:NhanVien
    {
        private int hsl, lcb;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap he so luong cua nhan vien: ");
            hsl = int.Parse(Console.ReadLine());
            Console.Write("Hay nhap luong co ban: ");
            lcb = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            TinhLuong();
        }
        public override void TinhLuong()
        {
            base.TinhLuong();
            luong = hsl * lcb;
        }
    }
}
