using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c3_p_bt6
{
    class DanhSachSinhVien
    {
        private int n;
        private SinhVien[] DS_SV;

        public void nhapds()
        {
            Console.WriteLine("Hay nhap so luong sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            DS_SV = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                DS_SV[i] = new SinhVien();
                DS_SV[i].nhap();
            }
        }
        public void xuatds()
        {
            for (int i=0; i < n; i++)
            {
                Console.WriteLine("Thong tin cua sinh vien thu {0}: ", i+1);
                DS_SV[i].xuat();
            }
            Console.ReadLine();
        }
    }
}
