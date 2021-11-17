using System;

namespace Chuong3_B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            Mang1Chieu myarray = new Mang1Chieu(n);
            myarray.NhapMang();
            myarray.InMang();
            myarray.sapxep(1);
            myarray.InMang();
            Console.Read();
        }
    }
}
