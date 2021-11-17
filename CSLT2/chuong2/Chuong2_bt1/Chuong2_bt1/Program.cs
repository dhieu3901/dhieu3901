using System;

namespace Chuong2_bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            sinhvien[] arraySV = new sinhvien[5]; //cap nhat cho mang
            int i;
            for (i = 0; i < 5; i++)
            {
                arraySV[i] = new sinhvien(); //cap nhat cho tung phan tu mang
                arraySV[i].nhapSV();
            }
            for (i = 0; i < 5; i++)
                arraySV[i].inSV();
            Console.Read();
        }
    }
}
