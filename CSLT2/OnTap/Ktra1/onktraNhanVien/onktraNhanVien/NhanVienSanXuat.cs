using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktraNhanVien
{
    class NhanVienSanXuat:NhanVien
    {
        protected int sosp;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap so san pham: ");
            sosp = int.Parse(Console.ReadLine());
            tinhluong();
        }
        public override void tinhluong()
        {
            luong = sosp * 30000;
            base.tinhluong();
        }
    }
}
