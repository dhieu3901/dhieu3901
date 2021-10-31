<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Sửa bác sĩ</title>
        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css" rel="stylesheet" />
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
    </head>
    <body class="sb-nav-fixed">
        <?php
        //viết các câu lệnh thêm mới tin tức ở đây

        include('config.php');

        //lấy ra được các dữ liệu mà trang TIN TỨC THÊM MỚI chuyển sang
        $bac_si_id=$_POST["txtID"];
        $ten_bac_si = $_POST["txtTen"];
        $chuc_vu = $_POST["txtChucVu"];
        $ghi_chu = $_POST["txtGhiChu"];
        //Xử lý hình ảnh --> chưa được
        $anh_minh_hoa = "../images/about/".basename($_FILES["txtAnhMinhHoa"]["name"]);
        $file_anh_tam=$_FILES["txtAnhMinhHoa"]["tmp_name"];
        //UPLOAD lên máy chủ web
        $result = move_uploaded_file($file_anh_tam, $anh_minh_hoa);
        if (!$result) {
            $anh_minh_hoa=NULL;
        } else {
            $anh_minh_hoa=basename($_FILES["txtAnhMinhHoa"]["name"]);
        }
        // 3. Viết câu lệnh truy vấn để sửa dữ liệu vào bảng TIN TỨC trong CSDL)
            if($anh_minh_hoa == NULL) {                         
                $sql = "
                        UPDATE tbl_bac_si 
                        SET ten_bac_si = '$ten_bac_si',chuc_vu = '$chuc_vu',ghi_chu ='$ghi_chu'
                        WHERE `bac_si_id` = '".$bac_si_id."'
                        ";
            } else {           
                $sql = "
                    UPDATE `tbl_bac_si` 
                    SET `ten_bac_si` = '$ten_bac_si',anh_minh_hoa = '$anh_minh_hoa',`chuc_vu` = '$chuc_vu',`ghi_chu` = '$ghi_chu'
                    WHERE `bac_si_id` = '".$bac_si_id."'
                    ";                
            }
        //echo $sql; exit();
        $noi_dung_bac_si=mysqli_query($ket_noi,$sql);

        // while ($row = mysql_fetch_array($noi_dung_tin_tuc)) {
        //  # code...
        // }
        // hiển thị ra thông báo bạn đã thêm mới tin tức thành công và đẩy các bạn về trang quản trị tin tức
        echo "
                <script type='text/javascript'>
                    window.alert('Bạn đã sửa bài viết thành công');
                </script>
            ";

            echo "
                <script type='text/javascript'>
                    window.location.href='quan_tri_bac_si.php';
                </script>
            ";
        ;?>
    </body>
</html>
