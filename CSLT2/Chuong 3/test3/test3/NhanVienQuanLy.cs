using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test3
{
    class NhanVienQuanLy:NhanVien
    {
        private float bl, lcb;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap bac luong cua nhan vien: ");
            bl = float.Parse(Console.ReadLine());
            Console.Write("Hay nhap luong co ban: ");
            lcb = float.Parse(Console.ReadLine());
        }
        public override void tinhluong()
        {
            luong = bl * lcb;
            base.tinhluong();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Bac luong cua nhan vien: {0}\nMuc luong co ban: {1}", bl, lcb);
            tinhluong();
        }
    }
}
