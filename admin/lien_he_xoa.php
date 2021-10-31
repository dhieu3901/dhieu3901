<?php
// Gan bien $id la id get duoc tu URL
$id = $_GET['id'];

// Thuc hien ket noi CSDL
include('config.php');
// Viet cau truy van thuc hien xoa ban ghi co id = $id
$sql = "DELETE FROM `tbl_lien_he` WHERE `tbl_lien_he`.`contact_id` = " .$id;

// Thuc hien cau truy van
$noi_dung_lien_he=mysqli_query($ket_noi,$sql);
     echo "
                <script type='text/javascript'>
                    window.alert('Bạn đã xóa bài viết thành công');
                </script>
            ";

        echo "
            <script type='text/javascript'>
                window.location.href='quan_tri_lien_he.php';
            </script>
        ";

?>