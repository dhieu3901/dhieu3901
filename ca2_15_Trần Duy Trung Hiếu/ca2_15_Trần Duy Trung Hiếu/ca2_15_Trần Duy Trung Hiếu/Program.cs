using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca2_15_Trần_Duy_Trung_Hiếu
{
    class Nguoi
    {
        string hoten;
        DateTime Ngaysinh;
        public float tien;

        public virtual void Nhap()
        {
            Console.Write("\nNhap ho ten cua giao vien: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap ngay sinh cua giao vien: ");
            Ngaysinh = Convert.ToDateTime(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.Write("Ho ten: {0}\nNgay sinh: {1}/{2}/{3}", hoten, Ngaysinh.Day, Ngaysinh.Month, Ngaysinh.Year);
        }

        public virtual void Thunhap()
        {
            Console.Write("\nThu nhap cua giao vien la: {0}", tien);
        }
    }
    class GiaoVien : Nguoi
    {
        string mgv, td, khoa ;
        float heso;
        public int chucvu;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ma giao vien: ");
            mgv = Console.ReadLine();
            Console.Write("Nhan vien thuoc khoa: ");
            khoa = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            heso = float.Parse(Console.ReadLine());
            Console.Write("Nhap trinh do: ");
            td = Console.ReadLine();
            Console.Write("Nhap chuc vu: \n1. Truong khoa\n2. Giao vien\nChon: ");
            chucvu = Int32.Parse(Console.ReadLine());
            
                
        }

        public override void Xuat()
        {
            base.Xuat();
            Thunhap();
            Console.Write("\nMa giao vien: {0} \nKhoa: {1} \nHe so luong: {2}\n", mgv, khoa, heso);
            if (chucvu == 1)
            {
                Console.WriteLine("Chuc vu: Truong khoa \n");
            }
            else
            {
                Console.WriteLine("Chuc vu: Giao vien \n");
            }
        }
        public override void Thunhap()
        {
            if (chucvu == 1)
            {
                tien = heso * 1150000 + 1000000;
            }
            else
            {
                tien = heso * 1150000;
            }
            base.Thunhap();
        }
    }
    class dsgv
    {
        private int n;
        private GiaoVien[] ds;
        public void Nhapds()
        {
            Console.Write("\nNhap so luong giao vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            ds = new GiaoVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Giao vien {0}", i + 1);
                ds[i] = new GiaoVien();
                ds[i].Nhap();
                Console.Write("\n");
            }
        }
        public void Xuatds()
        {
            Console.WriteLine("\n DANH SACH GIAO VIEN");
            for (int i = 0; i < n; i++)
            {
                ds[i].Xuat();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Nguoi x = new Nguoi();
            //x.Nhap();
            //x.Xuat();

            //GiaoVien y = new GiaoVien();
            //y.Nhap();
            //y.Xuat();

            dsgv z = new dsgv();
            z.Nhapds();
            z.Xuatds();
            Console.ReadLine();
        }
    }
}
