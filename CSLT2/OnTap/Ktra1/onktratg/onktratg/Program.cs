using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktratg
{
    class Program
    {
        static void Main(string[] args)
        {
            TuDien td = new TuDien();
            td.nhap();
            td.xuat();
            Console.Read();
        }
    }
}
