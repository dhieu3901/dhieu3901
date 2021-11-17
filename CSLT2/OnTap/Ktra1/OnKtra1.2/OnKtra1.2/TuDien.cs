using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnKtra1._2
{
    class TuDien:TamGiac
    {
        private double h;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap chieu cao cua tu dien: ");
            h = double.Parse(Console.ReadLine());
        }
        public double thetich()
        {
            return (h * dientich()) / 3;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("The tich cua tu dien la: {0}", thetich());
        }
    }
}
