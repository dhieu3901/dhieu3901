using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnKtra1._3
{
    class TienDien
    {
        protected string hoten, diachi;
        protected int stt, stn;
        public virtual void nhap()
        {
            Console.Write("Hay nhap ho ten chu ho: ");
            hoten = Console.ReadLine();
            Console.Write("Hay nhap dia chi chu ho: ");
            diachi = Console.ReadLine();
            Console.Write("Hay nhap so cong to thang truoc: ");
            stt = int.Parse(Console.ReadLine());
            Console.Write("Hay nhap so cong to thang nay: ");
            stn = int.Parse(Console.ReadLine());
        }
        public int sdd()
        {
            return stn - stt;
        }
        public virtual int thanhtien()
        {
            return sdd() * 500;
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ho ten chu ho: {0}\nDia chi: {1}\nSo cong to thang truoc: {2}\nSo cong to thang nay: {3}", hoten, diachi, stt, stn);
            Console.WriteLine("So cong to da dung: {0}\nThanh tien: {1}", sdd(), thanhtien());
        }
    }
}
