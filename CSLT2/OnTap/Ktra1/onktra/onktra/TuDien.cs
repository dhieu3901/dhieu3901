using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktra
{
    class TuDien:Tamgiac
    {
        private double h;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap chieu cao cua tu dien: ");
            h = Double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Chieu cao cua tu dien: {0}", h);
            Console.WriteLine("The tich: {0}", thetich());
        }
        public double thetich()
        {
            return h*dientich()/3;
        }
    }
}
