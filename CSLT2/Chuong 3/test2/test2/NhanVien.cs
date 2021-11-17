using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test2
{
    class NhanVien
    {
        protected string hoten, diachi;
        protected DateTime ngaysinh;
        protected float luong;
        public virtual void nhap()
        {
            Console.Write("Hay nhap ho ten cua nhan vien: ");
            hoten = Console.ReadLine();
            Console.Write("Hay nhap dia chi cua nhan vien: ");
            diachi = Console.ReadLine();
            Console.Write("Hay nhap ngay sinh cua nhan vien: ");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Thong tin cua nhan vien\nHo va ten: {0}\nDia chi: {1}\nNgay sinh: {2}/{3}/{4}", hoten, diachi, ngaysinh.Day, ngaysinh.Month, ngaysinh.Year);
        }
        public virtual void tinhluong()
        {
            Console.WriteLine("Luong cua nhan vien la: {0}", luong);
        }
    }
}
