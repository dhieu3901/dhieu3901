using System;

namespace Chuong3_B6
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.NhapSV();
            sv.InSV();

            SinhVien sv2 = new SinhVien("22A4040110", "Le Thi Hong", 2001, 10, 9);
            sv2.InSV();

            Console.Read();
        }
    }
}
