using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onktraNhanVien
{
    class NhanVien
    {
        protected string hoten, diachi;
        protected float luong;
        protected DateTime ngaysinh;
        public virtual void nhap()
        {
            Console.WriteLine("Hay nhap ho ten nhan vien: ");
            hoten = Console.ReadLine();
            Console.Write("Hay nhap dia chi cua nhan vien: ");
            diachi = Console.ReadLine();
            Console.Write("Hay nhap ngay sinh cua nhan vien: ");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Thong tin nhan vien\n\tHo ten: {0}\n\tDia chi: {1}\n\tNgay sinh: {2}/{3}/{4}", hoten, diachi, ngaysinh.Day, ngaysinh.Month, ngaysinh.Year);
        }
        public virtual void tinhluong()
        {
            Console.WriteLine("Luong cua nhan vien la: {0}", luong);
        }
        //write HAY nhap ho ten nhan vien
        // HAY NHAP HO TEN NHAN VIEN
        // ASDJSADJSAJDSADJSAJDASDKADJASD
    }
}

