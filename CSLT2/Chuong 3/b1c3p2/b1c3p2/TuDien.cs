using System;
using System.Collections.Generic;
using System.Text;

namespace b1c3p2
{
    class TuDien : TamGiac
    {
        protected double cao;
        public override void nhap()
        {
            Console.WriteLine("Nhap chieu cao: ");
            cao = double.Parse(Console.ReadLine());
            base.nhap();

        }
        private double Thetich()
        {
            return (1 / 3) * cao * Dientich();
            
        }
        public override void xuat()
        {
            Console.WriteLine("Chieu cao la:{0}", cao);
            base.xuat();
            Console.WriteLine("The tich la:{0}", Thetich());
         
        }
    }
}
