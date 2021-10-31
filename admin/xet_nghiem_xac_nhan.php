<?php
 include('config.php');
?>
 
<?php
// Gan bien $id la id get duoc tu URL
$id = $_GET['id'];
// Viet cau truy van thuc hien  ban ghi co id = $id
$sql = "UPDATE `tbl_xet_nghiem` SET `tinh_trang_thanh_toan` = '1' WHERE xet_nghiem_id = " .$id;

// Thuc hien cau truy van
if($ket_noi->query($sql)){
    echo "<script>
        alert('Cập nhật thành công');
        window.location = 'quan_tri_xet_nghiem.php';
        </script>";
}
else {
    echo"<script>
        alert('Không cập nhật được');
        window.location = 'quan_tri_xet_nghiem.php';
        </script>";
}
?>