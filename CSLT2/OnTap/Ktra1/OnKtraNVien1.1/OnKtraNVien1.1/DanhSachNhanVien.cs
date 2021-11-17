using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnKtraNVien1._1
{
    class DanhSachNhanVien
    {
        private int sonv;
        private NhanVien[] dsnv;
        public void nhap()
        {
            Console.Write("Hay nhap so nhan vien: ");
            sonv = Convert.ToInt32(Console.ReadLine());
            dsnv = new NhanVien[sonv];
            for (int i = 0; i < sonv; i++)
            {
                Console.WriteLine("Thong tin nhan vien thu {0}", i + 1);
                Console.WriteLine("Hay chon phan loai nhan vien\n\t1-Nhan vien san xuat\n\t2-Nhan vien cong nhat\n\t3-Nhan vien quan ly");
                int loainv = int.Parse(Console.ReadLine());
                if (loainv == 1)
                {
                    dsnv[i] = new NhanVienSanXuat();
                }
                if (loainv == 2)
                {
                    dsnv[i] = new NhanVienCongNhat();
                }
                if (loainv == 3)
                {
                    dsnv[i] = new NhanVienQuanLy();
                }
                dsnv[i].nhap();
            }
        }
        public void xuat()
        {
            for (int i=0; i<sonv; i++)
            {
                dsnv[i].xuat();
            }
        }
    }
}
