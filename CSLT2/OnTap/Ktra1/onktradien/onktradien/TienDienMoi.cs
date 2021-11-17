using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktradien
{
    class TienDienMoi:TienDien
    {
        private int dinhmuc;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap dinh muc: ");
            dinhmuc = int.Parse(Console.ReadLine());
        }
        public override int thanhtien()
        {
            if (sdd <= dinhmuc)
            {
                return base.thanhtien();
            }
            else return (sdd - dinhmuc) * 600 + dinhmuc * 500;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("\t Dinh muc: {0}", dinhmuc);
        }
    }
}
