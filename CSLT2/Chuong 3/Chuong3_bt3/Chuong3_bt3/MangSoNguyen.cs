using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_bt3
{
    class MangSoNguyen
    {
        private int n;
        int[] mang;

        public MangSoNguyen(int n)
        {
            this.n = n;
            mang = new int[n];
        }
        public void nhapMang()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Hay nhap vao phan tu {0} cua mang: ", i);
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void inMang()
        {
            Console.WriteLine("Xuat mang: ");
            //for (int i = 0; i < n; i++)
            //    Console.Write("{0}\t",a[i]);
            foreach (int x in mang)
            {
                Console.Write("{0}\t", x);
            }
        }
        public void sapXep(int thutu)
        {
            if (thutu == 0)
            {
                for (int i = 0; i < n-1; i++)
                    for (int j = i + 1; j < n; j++)
                    {
                        if (mang[i] < mang[j])
                        {
                            int z = mang[i];
                            mang[i] = mang[j];
                            mang[j] = z;
                        }
                    }
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                    {
                        if (mang[i] > mang[j])
                        {
                            int z = mang[i];
                            mang[i] = mang[j];
                            mang[j] = z;
                        }
                    }
            }
        }

    }
}
