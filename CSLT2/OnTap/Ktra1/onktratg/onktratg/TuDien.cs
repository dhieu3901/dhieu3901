using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktratg
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
            return h/3*dientich();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("\n\tChieu cao cua tu dien: {0}\n\tThe tich cua tu dien: {1}", h, thetich());
        }
    }
}
