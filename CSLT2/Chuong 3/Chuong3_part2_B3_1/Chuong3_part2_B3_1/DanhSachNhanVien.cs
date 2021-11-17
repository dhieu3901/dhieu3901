using System;

namespace Chuong3_part2_B3_1
{
    class DanhSachNhanVien
    {
        private int SoLuongNV;
        private NhanVien[] danhsach;
        public void NhapDS()
        {
            Console.Write("Nhap so luong nhan vien: ");
            SoLuongNV = Convert.ToInt32(Console.ReadLine());
            danhsach = new NhanVien[SoLuongNV];

            Console.WriteLine("\t1 - Nhan vien san xuat\t2 - Nhan vien cong nhat\t3 - Nhan vien quan ly");

            for (int i=0;i<SoLuongNV;i++)
            {
                Console.Write("Nhan vien thu {0} thuoc loai: ",i+1);
                int LoaiNV = Convert.ToInt32(Console.ReadLine());
                if (LoaiNV==1)
                {
                    danhsach[i] = new NhanVienSanXuat();
                }
                if (LoaiNV==2)
                {
                    danhsach[i] = new NhanVienCongNhat();
                }
                if (LoaiNV==3)
                {
                    danhsach[i] = new NhanVienQuanLy();
                }
                danhsach[i].Nhap();
            }
        }
        public void XuatDS()
        {
            for (int i=0; i<SoLuongNV; i++)
            {
                danhsach[i].Xuat();
                danhsach[i].TinhLuong();
            }
        }
    }
}
