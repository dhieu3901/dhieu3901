using System;

namespace Chuong3_part2_B3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.NhapDS();
            ds.XuatDS();
            Console.Read();
        }
    }
}
