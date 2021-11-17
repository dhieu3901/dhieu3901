using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test1
{
    class DanhSachNhanVien
    {
        private int snv;
        private NhanVien[] dsnv;
        public void nhap()
        {
            Console.Write("Nhap so nhan vien: ");
            snv = int.Parse(Console.ReadLine());
            dsnv = new NhanVien[snv];
            for (int i = 0; i < snv; i++)
            {
                Console.WriteLine("Nhap thong tin cua nhan vien thu {0}", i + 1);
                Console.Write("Hay chon phan loai nhan vien: ");
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
            for (int i=0;i<snv;i++)
            {
                dsnv[i].xuat();
            }    
        }
    }
}
