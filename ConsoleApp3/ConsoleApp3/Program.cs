using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*QUẢN LÝ NHÂN VIÊN
Xây dựng chương trình quản lý nhân viên cho một công ty. Mỗi người làm việc trong công ty cần quản lý Mã nhân viên, Họ tên, Ngày sinh, Chức vụ (gồm Trưởng phòng và Nhân viên), Phòng ban làm việc, Hệ số lương.
Chương trình cho phép thực hiện các chức năng sau:
1. Nhập vào một danh sách nhân viên
2. Tính thu nhập của nhân viên căn cứ vào chức vụ:
- Trưởng phòng: Thu nhập = Hệ số lương * 1.150.000 + 500.000
- Nhân viên: Thu nhập = Hệ số lương * 1.150.000
Xuất danh sách toàn bộ người làm việc trong công ty 
Hãy xây dựng các lớp và viết chương trình chính để thử nghiệm.
Hướng dẫn:
Xây dựng các lớp
1. Lớp Nguoi gồm:
- Dữ liệu: Họ tên, Ngày sinh
- Phương thức: Nhập, Xuất (phương thức ảo – virtual)
2. Lớp NhanVien kế thừa từ lớp Nguoi
- Bổ sung thêm thành phần dữ liệu: Mã nhân viên, Chức vụ, Phòng ban, Hệ số lương
- Bổ sung thêm phương thức Tính thu nhập (theo công thức trên)
- Điều chỉnh lại các phương thức Nhập, Xuất (ghi đè – override)
3. Lớp DanhSachNhanVien gồm:
- Dữ liệu: Số lượng nhân viên, Mảng một chiều để chứa danh sách nhân viên
- Phương thức: Nhập, Xuất
4. Lớp program để thử nghiệm */

class Program
{
    static void Main(string[] args)
    {
        dssv c = new dssv();
        c.nhapds();
        c.xuatds();
        Console.ReadLine();
    }
}