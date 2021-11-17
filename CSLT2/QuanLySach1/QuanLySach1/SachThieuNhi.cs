using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLySach1
{
    class SachThieuNhi:Sach
    {
        string Tacgia;
        public SachThieuNhi()
        {
            Tacgia = "";
            Tensach = "";
            Masach = "";
        }
        public SachThieuNhi(string Masach, string Tensach, string Tacgia)
        {
            this.Masach = Masach;
            this.Tensach = Tensach;
            this.Tacgia = Tacgia;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap ten tac gia: ");
            Tacgia = Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("\tTac gia: {0}", Tacgia);
        }
    }
}
