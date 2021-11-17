using System;

namespace Chuong3_B6
{
    class SinhVien
    {
        private string MSV, HoTen;
        private int NamSinh;
        private double DiemCSLT, DiemCSDL, DiemTB;

        public SinhVien()
        {
            MSV = HoTen = null;
            NamSinh = 0;
            DiemCSDL = DiemCSLT = DiemTB = 0;
        }

        public SinhVien(string MSV, string HoTen, int NamSinh,double DiemCSLT,double DiemCSDL )
        {
            this.MSV = MSV;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemCSLT = DiemCSLT;
            this.DiemCSDL = DiemCSDL;
        }

        public void NhapSV()
        {
            Console.Write("Nhap MSV      : ");
            MSV = Console.ReadLine();
            Console.Write("Nhap Ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh : ");
            NamSinh = int.Parse(Console.ReadLine());
            while (NamSinh <= 0 || NamSinh > 2021)
            {
                Console.Write("Nhap lai nam sinh: ");
                NamSinh = int.Parse(Console.ReadLine());
            }

            Console.Write("Nhap diem CSLT: ");
            DiemCSLT = double.Parse(Console.ReadLine());
            while(DiemCSLT<0 || DiemCSLT>10)
            {
                Console.Write("Nhap lai diem CSLT: ");
                DiemCSLT = double.Parse(Console.ReadLine());
            }

            Console.Write("Nhap diem CSDL: ");
            DiemCSDL = double.Parse(Console.ReadLine());
            while (DiemCSDL < 0 || DiemCSDL > 10)
            {
                Console.Write("Nhap lai diem CSDL: ");
                DiemCSDL = double.Parse(Console.ReadLine());
            }
        }

        public void InSV()
        {
            Console.WriteLine("MSV      : " + MSV);
            Console.WriteLine("Ho va ten: " + HoTen);
            Console.WriteLine("Nam sinh : " + NamSinh);
            Console.WriteLine("Diem CSLT: " + DiemCSLT);
            Console.WriteLine("Diem CSDL: " + DiemCSDL);
            Console.WriteLine("Diem TB  : {0}", (DiemCSDL + DiemCSLT) / 2);
        }
    }
}
