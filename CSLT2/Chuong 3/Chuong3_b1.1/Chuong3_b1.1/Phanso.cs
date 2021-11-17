using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_b1._1
{
    class PhanSO
    {
        private int mauso, tuso;

        public PhanSO()
        {
            tuso = 0;
            mauso = 1;
        }

        public PhanSO(int x)
        {
            tuso = x;
            mauso = 1;
        }
        public PhanSO(int a, int b)
        {
            tuso = a;
            mauso = b;
        }

        public void NhapPS()
        {
            Console.Write("Nhap tu so: ");
            tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            mauso = int.Parse(Console.ReadLine());
            while (mauso == 0)
            {
                Console.Write("Nhap lai mau so: ");
                mauso = int.Parse(Console.ReadLine());
            }
        }

        public void InPS()
        {
            Console.WriteLine("{0}/{1}", tuso, mauso);
        }

        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
                if (a > b) a -= b;
                else b -= a;
            return a;
        }

        public void Rutgon()
        {
            int k = UCLN(tuso, mauso);
            tuso = tuso / k;
            mauso = mauso / k;
        }

        public PhanSO CongPS(PhanSO ps1)
        {
            int TS = tuso * ps1.mauso + ps1.tuso * mauso;
            int MS = mauso * ps1.mauso;
            PhanSO KetQua = new PhanSO(TS, MS);
            return KetQua;
        }

        public PhanSO HieuPS(PhanSO ps1)
        {
            int TS = tuso * ps1.mauso - ps1.tuso * mauso;
            int MS = mauso * ps1.mauso;
            PhanSO KetQua = new PhanSO(TS, MS);
            return KetQua;
        }
        public PhanSO TichPS(PhanSO ps1)
        {
            int TS = tuso * ps1.tuso;
            int MS = mauso * ps1.mauso;
            PhanSO KetQua = new PhanSO(TS, MS);
            return KetQua;
        }
        public PhanSO ThuongPS(PhanSO ps1)
        {
            int TS = tuso * ps1.mauso;
            int MS = mauso * ps1.tuso;
            PhanSO KetQua = new PhanSO(TS, MS);
            return KetQua;
        }
    }
}
