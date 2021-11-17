using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktraNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien ds = new NhanVien();
            ds.nhap();
            ds.xuat();
            Console.Read();
        }
    }
}
