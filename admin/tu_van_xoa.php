<?php
//viết các câu lệnh thêm mới tin tức ở đây
include('config.php');

//lấy ra được các dữ liệu mà trang TIN TỨC THÊM MỚI chuyển sang
$tu_van_id=$_GET['id'];
$sql= "DELETE 
              FROM `tbl_tu_van` 
              WHERE `tbl_tu_van`.`tu_van_id` = '".$tu_van_id."'
";

$noi_dung=mysqli_query($ket_noi,$sql);
echo "
        <script type='text/javascript'>
            window.alert('Bạn đã xóa người đăng kí tư vấn thành công');
        </script>
    ";

echo "
    <script type='text/javascript'>
        window.location.href='quan_tri_dich_vu.php';
    </script>
";
;?>
