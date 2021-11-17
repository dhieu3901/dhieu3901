using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test2
{
    class NhanVienSanXuat:NhanVien
    {
        private int ssp;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap so san pham cua nhan vien: ");
            ssp = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So san pham cua nhan vien la: {0}", ssp);
            tinhluong();
        }
        public override void tinhluong()
        {
            luong = ssp * 30000;
            base.tinhluong();
        }
    }
}
