using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktratg1._1
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
            do
            {
                Console.Write("Hay nhap canh thu nhat cua tam giac: ");
                canh1 = Convert.ToDouble(Console.ReadLine());
            } while (canh1 <= 0);
            do
            {
                Console.Write("Hay nhap canh thu hai cua tam giac: ");
                canh2 = Convert.ToDouble(Console.ReadLine());
            } while (canh2 <= 0);
            do
            {
                Console.Write("Hay nhap canh thu ba cua tam giac: ");
                canh3 = Convert.ToDouble(Console.ReadLine());
            } while (canh3 <= 0);
            while (canh1 + canh2 <= canh3 || canh2 + canh3 <= canh1 || canh1 + canh3 <= canh2)
            {
                Console.WriteLine("Nhap lai ba canh");
                canh1 = Convert.ToDouble(Console.ReadLine());
                canh2 = Convert.ToDouble(Console.ReadLine());
                canh3 = Convert.ToDouble(Console.ReadLine());
            }
        }
        public virtual double dientich()
        {
            double p = (canh1 + canh2 + canh3) / 2;
            return Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
        }
        public virtual void xuat()
        {
            Console.WriteLine("Thong tin tam giac\n\tCanh 1: {0}\n\tCanh 2: {1}\n\t Canh 3: {2}\n\tDien tich cua tam giac: {3}", canh1, canh2, canh3, dientich());
        }
    }
}
