using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c3_nhanvien
{
    class NhanVien
    {
        protected string hoten, diachi;
        protected DateTime ngaysinh;
        protected float luong;

        public virtual void nhap()
        {
            Console.Write("Nhap vao ho ten nhan vien: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap vao dia chi nhan vien: ");
            diachi = Console.ReadLine();
            Console.Write("Nhap vao ngay sinh nhan vien: ");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Thong tin nhan vien:   HO & TEN : {0}, Dia chi: {1}, Ngay sinh: {2}/{3}/{4}", hoten, diachi, ngaysinh.Day, ngaysinh.Month, ngaysinh.Year);
        }

        public virtual void TinhLuong()
        {
            Console.WriteLine("Luong cua nhan vien: {0}", luong);
        }
    }
}