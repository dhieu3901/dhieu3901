using System;

namespace c3_nhanvien
{
    class NhanVienCongNhat : NhanVien
    {
        private int soNgayCong;
        public override void TinhLuong()
        {
            luong = (float)soNgayCong * 90000;
            base.TinhLuong();
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay cho biet so ngay cong: ");
            soNgayCong = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So ngay Cong: {0}", soNgayCong);
            TinhLuong();
        }
    }
}