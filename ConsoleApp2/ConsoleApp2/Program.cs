using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a :");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b :");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tong = {0}", a+b);
            Console.WriteLine("hieu = {0}",  a - b) ;
            Console.WriteLine("tich = {0}", a*b);
            Console.WriteLine("thuong = {0}", a/b);
            Console.ReadLine();
        }
    }
}
