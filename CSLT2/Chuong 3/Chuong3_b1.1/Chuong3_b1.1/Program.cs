using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_b1._1
{
        class Program
        {
            static void Main(string[] args)
            {
                PhanSO p1 = new PhanSO();
                p1.NhapPS();

                PhanSO p2 = new PhanSO();
                p2.NhapPS();

                Console.Write("Phan so 1: ");
                p1.InPS();
                Console.Write("Phan so 2: ");
                p2.InPS();

                //cộng 2 phân số 1 và 2
                PhanSO p3 = new PhanSO();
                p3 = p1.CongPS(p2);
                Console.Write("p1 + p2 = ");
                p3.Rutgon();
                p3.InPS();

                //trừ 2 phân số 1 và 2
                PhanSO p4 = new PhanSO();
                p4 = p1.HieuPS(p2);
                Console.Write("p1 - p2 = ");
                p4.Rutgon();
                p4.InPS();

                //nhân 2 phân số 1 và 2
                PhanSO p5 = new PhanSO();
                p5 = p1.TichPS(p2);
                Console.Write("p1 * p2 = ");
                p5.Rutgon();
                p5.InPS();

                //Chia 2 phân số 1 và 2
                PhanSO p6 = new PhanSO();
                p6 = p1.ThuongPS(p2);
                Console.Write("p1 / p2 = ");
                p6.Rutgon();
                p6.InPS();
                Console.Read();
            }
        }
}
