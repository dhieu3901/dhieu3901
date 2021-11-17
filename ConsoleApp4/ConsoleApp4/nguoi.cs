using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class nguoi
    {
        private string ht;
        private DateTime ns;
        public virtual void nhap()
        {
            Console.WriteLine(" Nhap ho ten: ");
            ht = Console.ReadLine();
            Console.WriteLine(" Nhap ngay sinh: ");
            ns = Convert.ToDateTime(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("\n Ho ten: {0}\n Ngay sinh: {1}/{2}/{3}", ht, ns.Day, ns.Month, ns.Year);
        }
    }
}
