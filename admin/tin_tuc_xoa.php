
        <?php
        //viết các câu lệnh thêm mới tin tức ở đây
        include('config.php');

        //lấy ra được các dữ liệu mà trang TIN TỨC THÊM MỚI chuyển sang
        $tin_tuc_id=$_GET['id'];
       


        //VIết câu lệnh truy vấn để thêm mới dữ liệu vào bảng TIN TỨC trong CSDL
        $sql= "DELETE 
                      FROM `tbl_tin_tuc` 
                      WHERE `tbl_tin_tuc`.`tin_tuc_id` = '".$tin_tuc_id."'
        ";

        $noi_dung_tin_tuc=mysqli_query($ket_noi,$sql);

        // while ($row = mysql_fetch_array($noi_dung_tin_tuc)) {
        //  # code...
        // 
        // hiển thị ra thông báo bạn đã thêm mới tin tức thành công và đẩy các bạn về trang quản trị tin tức
        echo "
                <script type='text/javascript'>
                    window.alert('Bạn đã xóa bài viết thành công');
                </script>
            ";

        echo "
            <script type='text/javascript'>
                window.location.href='quan_tri_tin_tuc.php';
            </script>
        ";
    ;?>
