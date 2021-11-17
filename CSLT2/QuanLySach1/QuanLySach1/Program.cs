using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLySach1
{
    class Program
    {
        static void Main(string[] args)
        {
            SachThieuNhi stn = new SachThieuNhi();
            stn.nhap();
            stn.xuat();
            Console.Read();
        }
    }
}
