using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_b1
{
    class PhanSo
    {
        private int TuSo;
        private int MauSo;

        public PhanSo()
        {
            TuSo=0;
            MauSo=1;
        }
    public void NhapPS()
    {
        Console.WriteLine("Nhap tu so: ");
        TuSo = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap mau so: ");
        MauSo = int.Parse(Console.ReadLine());
        while(MauSo==0)
        {
            Console.WriteLine("Nhap lai mau so: ");
            MauSo = int.Parse(Console.ReadLine());
        }
    }
    public void InPS()
    {
        Console.WriteLine("Gia tri cua phan so: {0}/{1}", TuSo, MauSo);
    }
    private int ucln(int a, int b)
    {
        int ucln = 1;
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (a != b)
            if (a > b) a -= b;
            else b -= a;
        ucln = a;
        return ucln;
    }
    public void rutgon_travechinhno()
    {
        int uc = ucln(TuSo, MauSo);
        TuSo = TuSo / uc;
            MauSo = MauSo / uc;
    }
    //puclic PhanSo rutgon()
    //  PhanSo p = new PhanSo();
    // int uc = ucln(TuSo,MauSo);
    // p.TuSo = TuSo/uc;
    // p.MauSo = MauSo/uc
    // return p
    }
}
