using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktra
{
    class Program
    {
        static void Main(string[] args)
        {
            TuDien tg = new TuDien();
            tg.nhap();
            tg.xuat();
            Console.Read();
        }
    }
}
