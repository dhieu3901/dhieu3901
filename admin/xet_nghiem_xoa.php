<?php
include('config.php');
?>
<?php
// Gan bien $id la id get duoc tu URL
$id = $_GET['id'];
// Viet cau truy van thuc hien xoa ban ghi co id = $id

$sql2 = "DELETE FROM `tbl_xet_nghiem` WHERE loai_id = " .$id;

// Thuc hien cau truy van 
if( $ket_noi->query($sql2)){
    echo "<script>
        alert('Xóa thành công');
        window.location = 'quan_tri_xet_nghiem.php';
        </script>";
}
else {
    echo"<script>
        alert('Không xóa được');
        window.location = 'quan_tri_xet_nghiem.php';
        </script>";
}
?>