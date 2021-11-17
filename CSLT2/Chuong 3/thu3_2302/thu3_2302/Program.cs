using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c3_nhanvien
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.nhap();
            ds.Xuat();
            Console.Read();
        }
    }
}
