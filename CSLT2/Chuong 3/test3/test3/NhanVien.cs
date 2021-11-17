using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test3
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
            Console.WriteLine("Thong tin cua nhan vien:\n\tHoten: {0}\n\tDia chi: {1}\n\tNgay sinh:{2}/{3}/{4}", hoten, diachi, ngaysinh.Day, ngaysinh.Month, ngaysinh.Year);
        }
        public virtual void tinhluong()
        {
            Console.WriteLine("Luong cua nhan vien la: {0}", luong);
        }
    }
}
