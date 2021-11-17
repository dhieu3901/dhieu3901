﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test2
{
    class DanhSachNhanVien
    {
        private int snv;
        private NhanVien[] dsnv;
        public void nhap()
        {
            Console.Write("Hay nhap so nhan vien: ");
            snv = int.Parse(Console.ReadLine());
            dsnv = new NhanVien[snv];
            for (int i = 0; i < snv; i++)
            {
                Console.WriteLine("Hay nhap thong tin cua nhan vien thu {0}", i + 1);
                Console.WriteLine("Hay lua chon phan loai nhan vien\n\t1-Nhan vien san xuat\n\t2-Nhan vien cong nhat\n\t3-Nhan vien quan ly");
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
            for(int i=0; i<snv; i++)
            {
                Console.WriteLine("Thong tin cua nhan vien thu {0}", i + 1);
                dsnv[i].xuat();
            }
        }
    }
}
