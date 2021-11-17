using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c3_p_bt6
{
    class SinhVien
    {
        private string masv, tensv;
        private int namSinh, thangSinh, ngaySinh;

        public SinhVien()
        {
            //write st
        }
        public SinhVien(string masv, string tensv, int namSinh, int thangSinh, int ngaySinh)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.namSinh = namSinh;
            this.thangSinh = thangSinh;
            this.ngaySinh = ngaySinh;
        }
        public void nhap()
        {
            Console.WriteLine("Hay nhap ten sinh vien: ");
            tensv = Console.ReadLine();
            Console.WriteLine("Hay nhap ma sinh vien: ");
            masv = Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("Ten va ma cua sinh vien la" + tensv + "," + masv);
        }

        public string MaSV
        {
            get { return masv; }
            set { masv = value; }
        }
        public string TenSV
        {
            get { return tensv; }
            set { tensv = value; }
        }
    }
}
