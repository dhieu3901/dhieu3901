<meta charset="UTF-8" />
<?php
    include('config.php');
    $to      = (string)$_POST['txtEmail'];
    $subject = 'PC-Covid';
    $message = 'Bạn đã đăng ký thành công nhận tin tức về COVID-19'."\n"
                ."\n".'     Truy cập trang COVID-19.php để biết thêm chi tiết.'
                ."\n".'     Mọi thông tin chi tiết vui lòng liên hệ:'
                ."\n".'     Hotline: 024 3825 5599'
                ."\n".'     Email: pccovid19s@gmail.com'
                ."\n".'     Đ/c: 36 Ngô Quyền, phường Hàng Bài,quận Hoàn Kiếm, Hà Nội';        
    $db = ("SELECT email FROM tbl_gui_email WHERE email='$to'");
    $query = $ket_noi->query($db);

    if (empty($_POST['txtEmail'])) { //Kiểm tra xem trường email có rỗng không?
        echo "
                <script type='text/javascript'>
                    window.alert('Đăng ký không thành công. Bạn phải nhập địa chỉ email');
                    window.location.href='index.php'
                </script>
            ";
    } elseif (!empty($_POST['txtEmail']) && !filter_var($_POST['txtEmail'], FILTER_VALIDATE_EMAIL)) {
        echo "
                <script type='text/javascript'>
                    window.alert('Đăng ký không thành công. Bạn phải nhập email đúng định dạng');
                    window.location.href='index.php'
                </script>
            ";
    }elseif(mysqli_fetch_array($query) > 0 ) { //check if there is already an entry for that username
        echo "
                <script type='text/javascript'>
                    window.alert('Đăng ký không thành công. Bạn đã đăng ký email này trước đó');
                    window.location.href='index.php'
                </script>
        ";
    }else {
        mail($to,$subject,$message);
        $sql = "INSERT INTO `tbl_gui_email` (`gui_email_id`, `email`) VALUES (NULL, '".$to."');";
        $noi_dung = mysqli_query($ket_noi,$sql);
        echo "
                <script type='text/javascript'>
                    window.alert('Bạn đã đăng ký thành công');
                    window.location.href='index.php'
                </script>
            ";
    }      
    
?>
