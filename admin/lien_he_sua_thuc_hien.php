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
        <title>Sửa liên hệ</title>
        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css" rel="stylesheet" />
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
        <script src="https://cdn.tiny.cloud/1/no-api-key/tinymce/5/tinymce.min.js" referrerpolicy="origin"></script>
        <script>
          tinymce.init({
          selector: '#txtMoTa',
          height: 500,
          plugins: 'print preview paste importcss searchreplace autolink autosave save directionality code visualblocks visualchars fullscreen image link media template codesample table charmap hr pagebreak nonbreaking anchor toc insertdatetime advlist lists wordcount imagetools textpattern noneditable help charmap quickbars emoticons',
          imagetools_cors_hosts: ['picsum.photos'],
          menubar: 'file edit view insert format tools table help',
          toolbar: 'undo redo | bold italic underline strikethrough | fontselect fontsizeselect formatselect | alignleft aligncenter alignright alignjustify | outdent indent |  numlist bullist | forecolor backcolor removeformat | pagebreak | charmap emoticons | fullscreen  preview save print | insertfile image media template link anchor codesample | ltr rtl',
          content_style: 'body { font-family:Helvetica,Arial,sans-serif; font-size:14px }'
        });
        </script>
        <script>
          
        tinymce.init({
          selector: '#txtNoiDung',
          height: 500,
          plugins: 'print preview paste importcss searchreplace autolink autosave save directionality code visualblocks visualchars fullscreen image link media template codesample table charmap hr pagebreak nonbreaking anchor toc insertdatetime advlist lists wordcount imagetools textpattern noneditable help charmap quickbars emoticons',
          imagetools_cors_hosts: ['picsum.photos'],
          menubar: 'file edit view insert format tools table help',
          toolbar: 'undo redo | bold italic underline strikethrough | fontselect fontsizeselect formatselect | alignleft aligncenter alignright alignjustify | outdent indent |  numlist bullist | forecolor backcolor removeformat | pagebreak | charmap emoticons | fullscreen  preview save print | insertfile image media template link anchor codesample | ltr rtl',
          content_style: 'body { font-family:Helvetica,Arial,sans-serif; font-size:14px }'
        });
        </script>
       

    </head>
    <body class="sb-nav-fixed">
       <?php

        include('config.php');

        $lien_he_id=$_POST["txtID"];
        $ten_nguoi_lien_he = $_POST["txtTen"];
        $email_nguoi_lien_he=$_POST["txtEmail"];
        $sdt_nguoi_lien_he = $_POST["txtSDT"];
        $noi_dung_lien_he =$_POST["txtNoiDung"];

        $sql="UPDATE `tbl_lien_he` SET `ten_nguoi_lien_he` = '".$ten_nguoi_lien_he."', `email_nguoi_lien_he` ='".$email_nguoi_lien_he."',`sdt_nguoi_lien_he`='".$sdt_nguoi_lien_he."', `noi_dung_lien_he`='".$noi_dung_lien_he."' WHERE `tbl_lien_he`.`lien_he_id` = '".$lien_he_id."'
        ";
        
        $noi_dung_nguoi_lien_he=mysqli_query($ket_noi,$sql);

         echo "
                <script type='text/javascript'>
                    window.alert('Bạn đã sửa người dùng thành công');
                </script>
            ";

            echo "
                <script type='text/javascript'>
                    window.location.href='quan_tri_lien_he.php';
                </script>
            ";
       ?>
    </body>
</html>
