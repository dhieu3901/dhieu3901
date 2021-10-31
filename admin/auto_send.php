<meta charset="UTF-8" />
<?php
    include('config.php');
    $sql = "SELECT * FROM tbl_gui_email";   
    $noi_dung = mysqli_query($ket_noi,$sql);
    

    while ($row = mysqli_fetch_array($noi_dung)) {
        $to      = (string)$row['email'];
        $subject = 'PC-Covid';
        $message = (string)$_POST['txtTieuDe']. "\n";
        mail($to,$subject,$message.' Truy cập trang COVID-19.php để biết thêm chi tiết');
    }
    
?>
