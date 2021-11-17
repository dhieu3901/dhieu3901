using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnKtra1._3
{
    class TienDienMoi:TienDien
    {
        private int sdm;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap dinh muc: ");
            sdm = int.Parse(Console.ReadLine());
        }
        public override int thanhtien()
        {
            if (sdd() < sdm)
            {
                return base.thanhtien();
            }
            else return (sdd() - sdm) * 600 + sdm * 500;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So dinh muc: {0}", sdm);
        }
    }
}
