
        <?php
        //viết các câu lệnh thêm mới tin tức ở đây
        include('config.php');

        //lấy ra được các dữ liệu mà trang TIN TỨC THÊM MỚI chuyển sang
       // $nguoi_dung_id = $_POST["txtID"];
        $ten_nguoi_dung = $_POST["txtTenNguoiDung"];
        $email=$_POST["txtEmail"];
        $mat_khau = $_POST["txtMatKhau"];
        $admin = $_POST["admin"];



        //VIết câu lệnh truy vấn để thêm mới dữ liệu vào bảng TIN TỨC trong CSDL
        $sql = " INSERT INTO `tbl_nguoi_dung`(`ten_nguoi_dung`, `email`,`mat_khau`,`last_login`, `admin`)
VALUES ('" .$ten_nguoi_dung."','".$email."','".$mat_khau."',current_timestamp(),'".$admin."')
        ";
        //echo $sql; exit();
        $noi_dung_nguoi_dung=mysqli_query($ket_noi,$sql);
        
        // while ($row = mysql_fetch_array($noi_dung_tin_tuc)) {
        // 	# code...
        // }
        // hiển thị ra thông báo bạn đã thêm mới tin tức thành công và đẩy các bạn về trang quản trị tin tức
         echo "
                <script type='text/javascript'>
                    window.alert('Bạn đã thêm người dùng thành công');
                </script>
            ";

            echo "
                <script type='text/javascript'>
                    window.location.href='quan_tri_nguoi_dung.php';
                </script>
            ";
        ;?>
    </body>
</html>
