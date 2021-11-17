using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C3_TienDien
{
    class DienMoi:TienDien
    {
        public int DinhMuc;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap Dinh Muc: ");
            DinhMuc = Convert.ToInt32(Console.ReadLine());
        }

        public override int TinhTien()
        {
            base.TinhTien();
            if (SoDaDung > DinhMuc) PhaiTra = (SoDaDung - DinhMuc) * 600 + DinhMuc * 500;
            else PhaiTra = SoDaDung * 500;
            return PhaiTra;
        }
    }
}
