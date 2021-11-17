using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnKtraNVien1._1
{
    class NhanVienQuanLy:NhanVien
    {
        private float baclg, lgcoban;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap bac luong: ");
            baclg = Convert.ToSingle(Console.ReadLine());
            Console.Write("Hay nhap luong co ban: ");
            lgcoban = Convert.ToSingle(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("\tBac luong: {0}\n\tLuong co ban: {1}", baclg, lgcoban);
            tinhluong();
        }
        public override void tinhluong()
        {
            luong = baclg * lgcoban;
            base.tinhluong();
        }
    }
}
