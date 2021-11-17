using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_B2
{
    class TOADO
    {
        private double hoanhdo, tungdo;
        public TOADO()
        {
            hoanhdo = tungdo = 0;
        }
        public TOADO(double x,double y)
        {
            hoanhdo = x;
            tungdo = y;
        }
        public void NhapTD()
        {
            Console.Write("Nhap Hoanh Do: ");
            hoanhdo = double.Parse(Console.ReadLine());
            Console.Write("Nhap Tung Do: ");
            tungdo = double.Parse(Console.ReadLine());
        }
        public void InTD()
        {
            Console.WriteLine("( {0} ; {1} )", hoanhdo, tungdo);
        }

        public double KHOANGCACH(TOADO diem1)
        {
            double kc = Math.Sqrt( (diem1.hoanhdo-hoanhdo)* (diem1.hoanhdo - hoanhdo)+(diem1.tungdo-tungdo)* (diem1.tungdo - tungdo));
            return kc;
        }
    }
}
