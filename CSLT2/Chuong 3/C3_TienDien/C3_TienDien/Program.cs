using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C3_TienDien
{
    class Program
    {
        static void Main(string[] args)
        {
            DienMoi hd = new DienMoi();
            hd.Nhap();
            hd.Xuat();
            Console.Read();
        }
    }
}
