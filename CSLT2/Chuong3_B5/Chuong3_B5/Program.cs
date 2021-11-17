using System;

namespace Chuong3_B5
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();
            nv.Nhap();
            nv.InNV();
            Console.Read();
        }
    }
}
