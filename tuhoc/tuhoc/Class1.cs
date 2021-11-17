using System;
using System.Collections.Generic;
using System.Linq;


namespace tuhoc
{
    class Class1

    {
        static void classsMain(string[] args)

        {
            int n, i;
            int[] a;
            Console.WriteLine("Nhap so luong phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Mang vua nhap la: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.ReadLine();
        }
    }
}
