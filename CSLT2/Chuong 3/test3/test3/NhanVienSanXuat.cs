using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test3
{
    class NhanVienSanXuat:NhanVien
    {
        private int sp;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap so san pham: ");
            sp = int.Parse(Console.ReadLine());
        }
        public override void tinhluong()
        {
            luong = sp * 30000;
            base.tinhluong();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So san pham cua nhan vien la: ");
            tinhluong();
        }
    }
}
