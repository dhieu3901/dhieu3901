using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_bt3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            MangSoNguyen myarray = new MangSoNguyen(n);
            myarray.nhapMang();
            myarray.inMang();
            myarray.sapXep(1);
            myarray.inMang();
            Console.Read();
        }
    }
}
