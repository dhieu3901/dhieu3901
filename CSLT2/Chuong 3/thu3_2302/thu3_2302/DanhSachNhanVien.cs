using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c3_nhanvien
{
    class DanhSachNhanVien
    {
        private int soLuong;
        private NhanVien[] danhSach;
        public void nhap()
        {
            Console.WriteLine("So luong nhan vien: ");
            soLuong = Convert.ToInt32(Console.ReadLine());
            danhSach = new NhanVien[soLuong];

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine("Nhap thong tin cua nhan vien thu {0}", i + 1);
                Console.WriteLine("Nhan vien thu {0} thuoc loai nao: xin hay chon 1-Nhan vien cong nhan, 2-Nhan vien san xuat, 3-Nhan vien quan ly", i + 1);
                int loainv = Convert.ToInt32(Console.ReadLine());
                if (loainv == 1)
                {
                    danhSach[i] = new NhanVienCongNhat();
                }
                if (loainv == 2)
                {
                    danhSach[i] = new NhanVienSanXuat();
                }
                if (loainv == 3)
                {
                    danhSach[i] = new NhanVienQuanLy();
                }
                danhSach[i].nhap();
            }
        }
        public void Xuat()
        {
            for (int i=0; i<soLuong; i++)
            {
                danhSach[i].Xuat();
            }
        }
    }
}
