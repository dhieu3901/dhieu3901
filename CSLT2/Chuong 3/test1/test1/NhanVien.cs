using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test1
{
    class NhanVien
    {
        protected string hoten, diachi;
        protected DateTime ngaysinh;
        protected float luong;
        public virtual void nhap()
        {
            Console.Write("Hay nhap ho ten nhan vien: ");
            hoten = Console.ReadLine();
            Console.Write("Hay nhap dia chia cua nhan vien: ");
            diachi = Console.ReadLine();
            Console.Write("Hay nhap ngay sinh cua nhan vien: ");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Thong tin cua nhan vien\nHo va ten: {0}\n Dia chi: {1}\n Ngay sinh: {2}/{3}/{4}", hoten, diachi, ngaysinh.Day, ngaysinh.Month, ngaysinh.Year);
        }
        public virtual void TinhLuong()
        {
            Console.WriteLine("Luong cua nhan vien: {0}", luong);
        }
    }   

}
