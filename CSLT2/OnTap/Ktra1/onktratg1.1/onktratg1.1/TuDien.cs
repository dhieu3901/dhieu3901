using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktratg1._1
{
    class TuDien:TamGiac
    {
        private double h;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap chieu cao cua tu dien: ");
            h = Convert.ToDouble(Console.ReadLine());
        }
        public double thetich()
        {
            return (h * dientich()) / 3;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("\tThe tich cua tu dien: {0}", thetich());
        }
    }
}
