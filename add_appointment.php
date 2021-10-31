<meta charset="utf-8" />
<?php 

    // 2. KẾT NỐI ĐẾN CSDL
    include('config.php');
    // 1. Đọc dữ liệu từ trang ĐĂNG NHẬP gửi sang
    $ho_ten = $_POST["txtHoTen"];
    $email = $_POST["txtEmail"];
    $sdt = $_POST["txtPhone"];
    $gioi_tinh = $_POST["txtGioiTinh"];
    $ngay_tu_van =$_POST["datetimepicker3"];
    $thoi_gian = $_POST["datetimepicker4"];
    $phuong_thuc = $_POST["txtPhuongThuc"];
    $ghi_chu = $_POST["txtGhiChu"];

    $to      = (string)$_POST['txtEmail'];
    $subject = 'PC-Covid';
    $message = 'Cảm ơn bạn '.$ho_ten .' đã đặt lịch tư vấn. Chúng tôi sẽ liên hệ để xác nhận với bạn sớm nhất có thể. '."\n"
                ."\n".'     Truy cập trang COVID-19.php để biết thêm chi tiết.'
                ."\n".'     Mọi thông tin chi tiết vui lòng liên hệ:'
                ."\n".'     Hotline: 024 3825 5599'
                ."\n".'     Email: pccovid19s@gmail.com'
                ."\n".'     Đ/c: 36 Ngô Quyền, phường Hàng Bài,quận Hoàn Kiếm, Hà Nội';

    // 3. Thực thi câu lệnh để xác định dữ liệu có khớp hay không?
    

        $sql = "INSERT INTO `tbl_tu_van` (`tu_van_id`, `ho_ten`, `gioi_tinh`, `email`, `sdt`, `ngay_tu_van`, `thoi_gian`, `phuong_thuc`, `ghi_chu`) 
            VALUES (NULL, '".$ho_ten."', '".$gioi_tinh."', '".$email."', '".$sdt."','".$ngay_tu_van."','".$thoi_gian."', '".$phuong_thuc."', '".$ghi_chu."')
        ";
        mail($to,$subject,$message);
        $thuc_hien_phan_hoi = mysqli_query($ket_noi, $sql);
        echo "  <script type='text/javascript'>
                    window.alert('Cảm ơn bạn đã gửi phản hồi cho chúng tôi.');
                    window.location.href='appointment.php'
                </script>
        ";


?>