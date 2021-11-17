using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktraNhanVien
{
    class NhanVienQuanLy:NhanVien
    {
        private float baclg;
        private int lcb;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap bac luong: ");
            baclg = float.Parse(Console.ReadLine());
            Console.Write("Hay nhap luong co ban: ");
            lcb = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("\tBac luong: {0}\n\tLuong co ban: {1}", baclg, lcb);
            tinhluong();
        }
        public override void tinhluong()
        {
            luong = baclg * lcb;
            base.tinhluong();
        }
    }
}
