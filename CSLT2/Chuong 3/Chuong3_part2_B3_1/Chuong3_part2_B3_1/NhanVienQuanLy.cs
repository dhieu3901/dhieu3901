using System;

namespace Chuong3_part2_B3_1
{
    class NhanVienQuanLy:NhanVien
    {
        public double luongcoban;
        public double heso;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap luong co ban: ");
            //luongcoban = Convert.ToSingle(Console.ReadLine());
            luongcoban = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so       : ");
            heso = double.Parse(Console.ReadLine());
            //heso = Convert.ToSingle(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Luong co ban cua nhan vien: " + luongcoban);
            Console.WriteLine("He so cua nhan vien: "+heso);
        }
        public override void TinhLuong()
        {
            luong = luongcoban * heso;
            base.TinhLuong();
        }
    }
}
