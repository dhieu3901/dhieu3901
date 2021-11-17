using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktra
{
    class Tamgiac
    {
        protected double canh1, canh2, canh3;
        public Tamgiac()
        {
            canh1 = canh2 = canh3 = 0;
        }
        public Tamgiac(double canh1,double canh2,double canh3)
        {
            this.canh1 = canh1;
            this.canh2 = canh2;
            this.canh3 = canh3;
        }
        public virtual void nhap()
        {
            Console.Write("Nhap canh 1: ");
            canh1 = Convert.ToDouble(Console.ReadLine());
            while (canh1 <= 0)
            {
                Console.Write("Nhap lai canh 1: ");
                canh1 = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Nhap canh 2: ");
            canh2 = Convert.ToDouble(Console.ReadLine());
            while (canh2 <= 0)
            {
                Console.Write("Nhap lai canh 2: ");
                canh2 = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Nhap canh 3: ");
            canh3 = Convert.ToDouble(Console.ReadLine());
            while (canh3 <= 0)
            {
                Console.Write("Nhap lai canh 3: ");
                canh3 = Convert.ToDouble(Console.ReadLine());
            }
            while (canh1 + canh2 <= canh3 || canh2 + canh3 <= canh1 || canh1 + canh3 <= canh2)
            {
                Console.WriteLine("Nhap lai 3 canh: ");
                canh1 = Convert.ToDouble(Console.ReadLine());
                canh2 = Convert.ToDouble(Console.ReadLine());
                canh3 = Convert.ToDouble(Console.ReadLine());
            }
        }
        public virtual void xuat()
        {
            Console.WriteLine("Canh thu nhat: {0}\nCanh thu hai: {1}\nCanh thu ba: {2}", canh1, canh2, canh3);
            Console.WriteLine("Dien tich cua tam giac: {0}", dientich());
        }
        public virtual double dientich()
        {
            double p = (canh1 + canh2 + canh3) / 2;
            return Math.Sqrt(p * (p - canh3) * (p - canh2) * (p - canh1));
        }
    }
}
