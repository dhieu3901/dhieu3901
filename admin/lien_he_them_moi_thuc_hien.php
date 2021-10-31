<?php 
    // Mục đích kiểm tra xem bạn có quyền truy cập trang này không thông qua BIẾN $_SESSION['da_dang_nhap']
    session_start();
    if (!$_SESSION["da_dang_nhap"]) {
        echo "
            <script type='text/javascript'>
                window.alert('Bạn không có quyền truy cập');
            </script>
        ";

        echo "
            <script type='text/javascript'>
                window.location.href='dang_nhap.php';
            </script>
        ";
    }
;?>
<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Thêm mới liên hệ</title>
        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css" rel="stylesheet" />
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
    </head>
    <body class="sb-nav-fixed">
        <?php
        //viết các câu lệnh thêm mới tin tức ở đây
        include('config.php');

        //lấy ra được các dữ liệu mà trang TIN TỨC THÊM MỚI chuyển sang
        $ten_nguoi_lien_he = $_POST["txtTen"];
        $email_nguoi_lien_he=$_POST["txtEmai"];
        $sdt_nguoi_lien_he = $_POST["txtSDT"];
        $noi_dung_lien_he =$_POST["txtNoiDung"];
        
        $sql="INSERT INTO `tbl_lien_he` (`ten_nguoi_lien_he`, `email_nguoi_lien_he`, `sdt_nguoi_lien_he`, `noi_dung_lien_he`) VALUES ('".$ten_nguoi_lien_he."', '".$email_nguoi_lien_he."', '".$sdt_nguoi_lien_he."', '".$noi_dung_lien_he."')";
        
        $noi_dung_lien_he=mysqli_query($ket_noi,$sql);

        // while ($row = mysql_fetch_array($noi_dung_tin_tuc)) {
        // 	# code...
        // 
        // hiển thị ra thông báo bạn đã thêm mới tin tức thành công và đẩy các bạn về trang quản trị tin tức
         echo "
                <script type='text/javascript'>
                    window.alert('Bạn đã thêm liên hệ thành công');
                </script>
            ";

            echo "
                <script type='text/javascript'>
                    window.location.href='quan_tri_lien_he.php';
                </script>
            ";
        ;?>
    </body>
</html>
