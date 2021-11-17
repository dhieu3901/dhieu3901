using System;

namespace Chuong3_part2_B1
{
    class TamGiac
    {
        protected double canh_1, canh_2, canh_3;
        public virtual void Nhap()
        {
            Console.Write("Nhap canh 1: ");
            canh_1 = Convert.ToDouble(Console.ReadLine());
            while (canh_1 <= 0)
            {
                Console.Write("Nhap lai canh 1: ");
                canh_1 = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Nhap canh 2: ");
            canh_2 = Convert.ToDouble(Console.ReadLine());
            while (canh_2 <= 0)
            {
                Console.Write("Nhap lai canh 2: ");
                canh_2 = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Nhap canh 3: ");
            canh_3 = Convert.ToDouble(Console.ReadLine());
            while (canh_3 <= 0)
            {
                Console.Write("Nhap lai canh 3: ");
                canh_3 = Convert.ToDouble(Console.ReadLine());
            }
            while ( canh_1 + canh_2 <= canh_3 || canh_2 + canh_3 <= canh_1 || canh_1 + canh_3 <= canh_2 )
            {
                Console.WriteLine("Nhap lai 3 canh: ");
                canh_1 = Convert.ToDouble(Console.ReadLine());
                canh_2 = Convert.ToDouble(Console.ReadLine());
                canh_3 = Convert.ToDouble(Console.ReadLine());
            }
        }

        public virtual void Xuat()
        {
            Console.WriteLine(" Do dai 3 canh cua tam giac: ( {0} ; {1} ; {2} )", canh_1, canh_2, canh_3);
            Console.WriteLine("Dien tich tu dien: {0}", DienTich());
        }

        public virtual double DienTich()
        {
            double p = (canh_1 + canh_2 + canh_3) / 2;
            return Math.Sqrt(p * (p - canh_1) * (p - canh_2) * (p - canh_3));
        }
    }
}
