using System;

namespace Chuong3_B5
{
    class NhanVien
    {
        private string HoTen, DiaChi;
        private double HeSo, TongTien;
        private int NamSinh, LuongCB, PhuCap;

        public NhanVien()
        {
            HoTen = DiaChi = null;
            HeSo = TongTien = 0;
            NamSinh = 0;
            LuongCB = PhuCap = 0;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            while (NamSinh<=0 || NamSinh>2021)
            {
                Console.Write("Nhap lai nam sinh: ");
                NamSinh = int.Parse(Console.ReadLine());
            }

            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();

            Console.Write("Nhap luong co ban: ");
            LuongCB = int.Parse(Console.ReadLine());
            while (LuongCB<0)
            {
                Console.Write("Nhap lai luong co ban: ");
                LuongCB = int.Parse(Console.ReadLine());
            }

            Console.Write("Nhap phu cap: ");
            PhuCap = int.Parse(Console.ReadLine());
            while (PhuCap < 0)
            {
                Console.Write("Nhap lai luong co ban: ");
                PhuCap = int.Parse(Console.ReadLine());
            }

            Console.Write("Nhap He so: ");
            HeSo = double.Parse(Console.ReadLine());
            while (HeSo < 0)
            {
                Console.Write("Nhap lai luong co ban: ");
                HeSo = double.Parse(Console.ReadLine());
            }
        }

        public double TinhLuong()
        {
            return TongTien = LuongCB * HeSo + PhuCap;
        }

        public void InNV()
        {
            Console.WriteLine("Ho va ten: " + HoTen);
            Console.WriteLine("Dia chi  : " + DiaChi);
            Console.WriteLine("Nam sinh : " + NamSinh);
            Console.WriteLine("Luong CB : " + LuongCB);
            Console.WriteLine("He so    : " + HeSo);
            Console.WriteLine("Phu cap  : " + PhuCap);
            Console.WriteLine("Tong tien: " + TinhLuong());
        }




    }
}
