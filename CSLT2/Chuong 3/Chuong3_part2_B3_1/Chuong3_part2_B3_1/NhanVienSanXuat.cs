using System;

namespace Chuong3_part2_B3_1
{
    class NhanVienSanXuat: NhanVien
    {
        public int SoLuongSP;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so luong san pham: ");
            //SoLuongSP = Convert.ToInt32(Console.ReadLine());
            SoLuongSP = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So luong san pham cua nhan vien: " + SoLuongSP);
        }
        public override void TinhLuong()
        {
            luong = 30000 * (double)SoLuongSP;
            base.TinhLuong();
        }
    }
}
