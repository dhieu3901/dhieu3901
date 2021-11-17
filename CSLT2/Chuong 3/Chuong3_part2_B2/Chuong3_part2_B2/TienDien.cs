using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_part2_B2
{
    class TienDien
    {
        protected string HoTen,DiaChi;
        protected int SoThangTruoc, SoThangSau,PhaiTra;
        public TienDien()
        {
            HoTen = "";
            DiaChi = "";
            SoThangSau = SoThangTruoc = 0;
        }
        public TienDien(string _HoTen, string _DiaChi, int _SoThangTruoc, int _SoThangSau)
        {
            this.HoTen = _HoTen;
            this.DiaChi = _DiaChi;
            this.SoThangTruoc = _SoThangTruoc;
            this.SoThangSau = _SoThangSau;
        }

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
