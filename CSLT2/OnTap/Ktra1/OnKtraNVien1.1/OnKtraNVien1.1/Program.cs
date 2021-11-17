using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnKtraNVien1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.nhap();
            ds.xuat();
            Console.Read();
        }
    }
}
