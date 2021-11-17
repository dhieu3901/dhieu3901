using System;

namespace c3_nhanvien
{
    class NhanVienSanXuat : NhanVien
    {
        private int soSanPham;

        public override void nhap()
        {
            base.nhap();
            Console.Write("So luong san pham cua nhan vien: ");
            soSanPham = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So luong san pham cua nhan vien: {0}", soSanPham);
            TinhLuong();
        }

        public override void TinhLuong()
        {
            luong = (float)soSanPham * 30000;
            base.TinhLuong();
        }
    }
}