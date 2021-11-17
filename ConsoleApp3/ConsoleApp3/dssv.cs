using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class dssv
{
    int n;
    sinhvien[] ds;
    public void nhapds()
    {
        Console.WriteLine("\n Nhap so luong sinh vien: ");
        n = Convert.ToInt32(Console.ReadLine());
        ds = new sinhvien[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(" Nhap sinh vien thu {0}", i + 1);
            ds[i] = new sinhvien();
            ds[i].nhap();
        }
    }
    public void xuatds()
    {
        Console.WriteLine("\n DANH SACH SINH VIEN");
        for (int i = 0; i < n; i++)
        {
            ds[i].xuat();
        }
    }
}
