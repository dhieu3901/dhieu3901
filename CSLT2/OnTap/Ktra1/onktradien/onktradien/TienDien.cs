using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktradien
{
    class TienDien
    {
        protected string hoten, diachi;
        protected int stt, stn;
        public virtual void nhap()
        {
            Console.Write("Hay nhap ho ten chu ho: ");
            hoten = Console.ReadLine();
            Console.Write("Hay nhap dia chi: ");
            diachi = Console.ReadLine();
            Console.Write("Hay nhap so cong to thang truoc: ");
            stt = int.Parse(Console.ReadLine());
            Console.Write("Hay nhap so cong to thang nay: ");
            stn = int.Parse(Console.ReadLine());
        }
        public int sdd
        {
            get { return stn - stt; }
        }
        public virtual int thanhtien()
        {
            return sdd * 500;
        }
        public virtual void xuat()
        {
            Console.WriteLine("Thong tin\n\tHo ten chu ho: {0}\n\tDia chi: {1}\n\tSo cong to thang truoc: {2}" +
                "\n\tSo cong to thang nay: {3}\n\tSo cong to da dung: {4}\n\tThanh tien: {5}",hoten,diachi,stt,stn,sdd,thanhtien());
        }
    }
}
