using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_B2
{
    class Program
    {
        static void Main(string[] args)
        {
            TOADO diem1 = new TOADO();
            diem1.NhapTD();

            TOADO diem2 = new TOADO();
            diem2.NhapTD();

            Console.Write("Diem vua nhap: \n");
            diem1.InTD();
            diem2.InTD();

            Console.WriteLine("Khoang cach giua 2 diem: {0}", diem1.KHOANGCACH(diem2));
            Console.Read();
        }
    }
}
