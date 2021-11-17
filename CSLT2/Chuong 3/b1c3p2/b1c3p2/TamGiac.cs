using System;
using System.Collections.Generic;
using System.Text;

namespace b1c3p2
{
    class TamGiac
    {
        protected double canh1, canh2, canh3;
        public virtual void nhap()
        {
            Console.WriteLine("Nhap canh 1: ");
            canh1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh 2: ");
            canh2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh 3: ");
            canh3 = Convert.ToInt32(Console.ReadLine());
        }
       
     
        public virtual void xuat()
        {
            Console.WriteLine("Canh1: {0}, Canh2: {1}, Canh3: {2}", canh1, canh2, canh3);
            Console.WriteLine("Dien tich la: {0}", Dientich());
        }
        public virtual double Dientich()
        {
            double nuacv = (canh1 + canh2 + canh3) / 2;

            return Math.Sqrt((nuacv * (nuacv - canh1) * (nuacv - canh2) * (nuacv - canh3)));

        }

    }
}
