using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_b1
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo p = new PhanSo();
            p.NhapPS();
            p.rutgon_travechinhno();
            Console.WriteLine("Phan so 1: ");
            p.InPS();
        }
    }
}
