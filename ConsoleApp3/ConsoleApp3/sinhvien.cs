using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class sinhvien : nguoi
{
    private string msv;
    public string lop, khoa;
    public double dtb, drl;
    public override void nhap()
    {
        base.nhap();
        Console.WriteLine(" Nhap ma sinh vien: ");
        msv = Console.ReadLine();
        Console.WriteLine(" Nhap lop: ");
        lop = Console.ReadLine();
        Console.WriteLine(" Nhap khoa: ");
        khoa = Console.ReadLine();
        Console.WriteLine(" Nhap diem trung binh: ");
        dtb = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" Nhap diem ren luyen: ");
        drl = Convert.ToDouble(Console.ReadLine());
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine(" Ma sinh vien: {0}\n Lop: {1}\n Khoa: {2}\n Diem trung binh: {3}\n Diem ren luyen: {4}", msv, lop, khoa, dtb, drl);
        tn();
    }
    public void tn()
    {
        if (dtb >= 5 && drl >= 50)
            Console.WriteLine(" Du DK tot nghiep");
        else
            Console.WriteLine(" Ko du DK tot nghiep");
    }

}