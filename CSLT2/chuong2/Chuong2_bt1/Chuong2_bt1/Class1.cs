using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong2_bt1
{
    class sinhvien
    {
        string hoten;
        string masv;
        public void nhapSV()
        {
            Console.Write("Nhap vao ho va ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhao voa ma sv: ");
            masv = Console.ReadLine();
        }
        public void inSV()
        {
            Console.WriteLine("Ho va ten: {0} , ma sinh vien: {1} ", hoten, masv);
        }
    }
}
