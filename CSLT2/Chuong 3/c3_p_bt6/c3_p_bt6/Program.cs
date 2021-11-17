using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c3_p_bt6
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachSinhVien ds = new DanhSachSinhVien();
            ds.nhapds();
            ds.xuatds();

            SinhVien sv1 = new SinhVien();
            sv1.MaSV = "001";
            sv1.TenSV = "Nguyen Thi A";
            sv1.xuat();
            Console.ReadLine();
        }
    }
}
