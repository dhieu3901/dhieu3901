using System;

namespace Chuong3_part2_B3_1
{
    class NhanVienCongNhat: NhanVien
    {
        public int SoNgayCong;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so ngay cong: ");
            SoNgayCong = Convert.ToInt32(Console.ReadLine());
        }

        public override void TinhLuong()
        {
            luong = (double)SoNgayCong * 90000;
            base.TinhLuong();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So ngay cong cua nhan vien: " + SoNgayCong);
        }
    }
}
