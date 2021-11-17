using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_part2_B2
{
    class Program
    {
        static void Main(string[] args)
        {
            TienDienMoi hd = new TienDienMoi();
            hd.Nhap();
            hd.Xuat();
            Console.Read();
        }
    }
}
