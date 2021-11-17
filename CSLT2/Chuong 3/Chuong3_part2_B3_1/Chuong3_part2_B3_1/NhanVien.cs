using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_part2_B3_1
{
    class NhanVien
    {
        protected string hoten, diachi;
        protected DateTime ngaysinh;
        protected double luong;

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten nhan vien:");
            hoten = Console.ReadLine();
            Console.Write("Nhap dia chi nhan vien: ");
            diachi = Console.ReadLine();
            Console.Write("Nhap ngay sinh nhan vien: ");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ho va ten nhan vien: " + hoten);
            Console.WriteLine("Dia chi nhan vien  : " + diachi);
            Console.WriteLine("Ngay sinh nhan vien: {0} / {1} / {2} ", ngaysinh.Day, ngaysinh.Month, ngaysinh.Year);
        }

        public virtual void TinhLuong()
        {
            Console.WriteLine("Luong cua nhan vien: " + luong);
        }
    }
}
