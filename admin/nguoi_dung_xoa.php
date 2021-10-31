
        <?php
        //viết các câu lệnh thêm mới tin tức ở đây
        include('config.php');

        //lấy ra được các dữ liệu mà trang TIN TỨC THÊM MỚI chuyển sang
        $nguoi_dung_id=$_GET['id'];

        //VIết câu lệnh truy vấn để thêm mới dữ liệu vào bảng TIN TỨC trong CSDL
        $sql= "DELETE FROM `tbl_nguoi_dung` WHERE `tbl_nguoi_dung`.`nguoi_dung_id` = '".$nguoi_dung_id."'
        ";

        $noi_dung_nguoi_dung=mysqli_query($ket_noi,$sql);
         echo "
                <script type='text/javascript'>
                    window.alert('Bạn đã xóa người dùng thành công');
                </script>
            ";

            echo "
                <script type='text/javascript'>
                    window.location.href='quan_tri_nguoi_dung.php';
                </script>
            ";
        ;?>
