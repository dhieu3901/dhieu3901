using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_B3
{
    class Mang1Chieu
    {
        private int n;
        int[] mang;
        public Mang1Chieu(int n)
        {
            this.n = n;
            mang = new int[n];
        }
        public void NhapMang()
        {
            for (int i=0; i<n; i++)
            {
                //mang[i] = new int();
                Console.Write("a[{0}] = ",i);
                mang[i] = int.Parse(Console.ReadLine());
                //mang[i]=Convert.ToInt32(Console.readline())
            }
        }
        public void InMang()
        {
            Console.WriteLine("Xuat mang: ");
            //for (int i = 0; i < n; i++)
            //    Console.Write("{0}\t",a[i]);
            foreach (int x in mang)
            {
                Console.Write("{0}\t",x);
            }
        }

        public void sapxep(int thutu)
        {
            if (thutu == 0)
            {
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        if (mang[i] > mang[j])
                        {
                            int tg = mang[i];
                            mang[i] = mang[j];
                            mang[j] = tg;
                        }
            } 
            else if (thutu == 1)
            {
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        if (mang[i] < mang[j])
                        {
                            int tg = mang[i];
                            mang[i] = mang[j];
                            mang[j] = tg;
                        }
            }
            
        }
    }
}
