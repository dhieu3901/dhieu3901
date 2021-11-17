using System;


namespace c3_nhanvien
{
    class NhanVienQuanLy : NhanVien
    {
        private float hesoluong, luongcoban;
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap he so luong: ");
            //hesoluong = Convert.ToSingle(Console.ReadLine());
            hesoluong = float.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban: ");
            luongcoban = float.Parse(Console.ReadLine());
        }

        public override void TinhLuong()
        {
            luong = hesoluong * luongcoban;
            base.TinhLuong();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("He so luong: {0}\n Luong co ban: {1}", hesoluong, luongcoban);
            TinhLuong();
        }
    }
}