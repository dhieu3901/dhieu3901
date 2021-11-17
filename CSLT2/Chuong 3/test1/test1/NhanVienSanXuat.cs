using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test1
{
    class NhanVienSanXuat:NhanVien
    {
        private int sp;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Hay nhap so san pham cua nhan vien: ");
            sp = Convert.ToInt32(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So san pham cua nhan vien: {0}", sp);
            TinhLuong();
        }
        public override void TinhLuong()
        {
            luong = (float)sp * 30000;
            base.TinhLuong();
        }

    }
}
