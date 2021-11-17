using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test2
{
    class NhanVienQuanLy:NhanVien
    {
        private float hsl, lcb;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap he so luong cua nhan vien: ");
            hsl = float.Parse(Console.ReadLine());
            Console.Write("Hay nhap luong co ban cua nhan vien: ");
            lcb = float.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.Write("\n\tHe so luong cua nhan vien la: {0}", hsl);
            Console.Write("\n\tLuong co ban cua nhan vien la: {0}", lcb);
            tinhluong();
        }
        public override void tinhluong()
        {
            luong = hsl * lcb;
            base.tinhluong();
        }
    }
}
