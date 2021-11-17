using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnKtra1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            TienDienMoi tdm = new TienDienMoi();
            tdm.nhap();
            tdm.xuat();
            Console.Read();
        }
    }
}
