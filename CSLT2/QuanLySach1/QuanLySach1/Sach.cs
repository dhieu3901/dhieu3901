using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLySach1
{
    class Sach
    {
        protected string Masach, Tensach;
        public Sach()
        {
            Masach = "";
            Tensach = "";
        }
        public Sach(string Masach,string Tensach)
        {
            this.Masach = Masach;
            this.Tensach = Tensach;
        }
        public virtual void nhap()
        {
            Console.Write("Hay nhap ma sach: ");
            Masach = Console.ReadLine();
            Console.Write("Hay nhap ten sach: ");
            Tensach = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.WriteLine("Thong tin sach\n\tMa sach: {0}\n\tTen sach: {1}", Masach, Tensach);
        }
    }
}
