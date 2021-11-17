using System;

namespace Chuong3_part2_B1
{
    class TuDien:TamGiac
    {
        protected double chieuCao;
        public override void Nhap()
        {
            Console.Write("Nhap chieu cao cua tu dien: ");
            chieuCao = double.Parse(Console.ReadLine());
            base.Nhap();
        }

        
        private double TheTich()
        {
            return chieuCao * DienTich() / 3;
        }
        public override void Xuat()
        {
            Console.WriteLine("Chieu cao cua tu dien: {0}", chieuCao);
            base.Xuat();
            Console.WriteLine("The tich cua tu dien: {0}", TheTich());
        }
    }
}
