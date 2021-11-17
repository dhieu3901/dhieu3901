using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C3_TienDien
{
    class TienDien
    {
        protected string HoTen, DiaChi;
        protected int SoThangTruoc, SoThangSau, PhaiTra;
        
        public int SoDaDung
        {
            get { return SoThangSau - SoThangTruoc; }
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten ho dan: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi ho dan: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap so cong to thang truoc: ");
            SoThangTruoc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cong to thang sau: ");
            SoThangSau = Convert.ToInt32(Console.ReadLine());
        }

        public virtual int TinhTien()
        {
            PhaiTra = SoDaDung * 500;
            return PhaiTra;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ho va ten  : " + HoTen);
            Console.WriteLine("Dia chi    : " + DiaChi);
            Console.WriteLine("Thang truoc: " + SoThangTruoc);
            Console.WriteLine("Thang sau  : " + SoThangSau);
            Console.WriteLine("Tong tien  : " + TinhTien());
        }
    }
}
