using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktratg
{
    class TamGiac
    {
        protected double canh1, canh2, canh3;
        public TamGiac()
        {
            canh1 = canh2 = canh3 = 0;
        }
        public TamGiac(double canh1, double canh2, double canh3)
        {
            this.canh1 = canh1;
            this.canh2 = canh2;
            this.canh3 = canh3;
        }
        public virtual void nhap()
        {
            Console.Write("Hay nhap canh thu nhat: ");
            canh1 = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap canh thu hai: ");
            canh2 = double.Parse(Console.ReadLine());
            Console.Write("Hay nhap canh thu ba: ");
            canh3 = double.Parse(Console.ReadLine());
        }
        public double dientich()
        {
            double p = (canh1 + canh2 + canh3) / 2;
            return Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ba canh cua tam giac\n\tCanh 1: {0}\n\tCanh 2: {1}\n\tCanh 3: {2}\n\tDien tich: {3}",canh1,canh2,canh3,dientich());
        }
    }
}
