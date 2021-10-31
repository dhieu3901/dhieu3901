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
        <title>Sửa tin tức</title>
        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css" rel="stylesheet" />
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://kit.fontawesome.com/e40576cb0c.js" crossorigin="anonymous"></script>
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
    </head>
    <body class="sb-nav-fixed">
        <?php
            include("simple-sidebar.php");
        ?>
            <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid px-4">
                        <h1 class="mt-4">Quản trị dịch vụ</h1>
                        <p><b>Các loại hình xét nghiệm trung tâm cung cấp</p>
                        <ol class="breadcrumb mb-4">
                        </ol>
                        <div class="card mb-4">
                            <div class="card-header">
                                <i class="fas fa-hand-holding-medical"></i>
                                 <a class="btn btn-info" href="loai_xet_nghiem.php" style="float: right; margin-right: 14px"> Trở lại</a>
                            </div>
                            <div class="card-body">
                            <?php
                            
                            //1. 1. Kết nối đến MÁY CHỦ DỮ LIỆU & ĐẾN CSDL 
                            include('config.php');
                            // 2. Viết câu lệnh truy vấn để lấy ra được DỮ LIỆU MONG MUỐN (TIN TỨC đã lưu trong CSDL)
                            $loai_id=$_GET["id"];

                            $sql="SELECT * 
                                    FROM tbl_loai_xet_nghiem 
                                    WHERE loai_id= ".$loai_id."
                                    ORDER BY  loai_id DESC";
                            // 3. Thực thi câu lệnh truy vấn (mục đích trả về dữ liệu các bạn cần)
                            $noi_dung=mysqli_query($ket_noi,$sql);
                            //4.
                            $row = mysqli_fetch_array($noi_dung);
                                       
                            ;?>
                                <form method="POST" action="loai_xet_nghiem_sua_thuc_hien.php" enctype="multipart/form-data">
                                    <div class="form-floating mb-3">
                                        <input class="form-control" id="txtTenLoai" name="txtTenLoai" placeholder="Tên loại xét nghiệm COVID-19" value="<?php echo $row['ten_loai'];?>" />
                                            <label for="txtTenLoai">Tên loại xét nghiệm COVID-19</label>
                                    </div>

                                    <div class="form-floating mb-3">
                                            <input type="file" class="form-control"  name="txtAnhMinhHoa" id="txtAnhMinhHoa" />
                                                <label for="txtAnhMinhHoa">Ảnh minh họa</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                         <textarea class="form-control" id="txtMoTa" name="txtMoTa" placeholder="Mô tả loại hình xét nghiệm"><?php echo $row['mo_ta'];?></textarea>
                                            <label for="txtMoTa">Mô tả loại xét nghiệm</label>
                                    </div>
                                    
                                        <div class="form-floating mb-3">
                                            <input class="form-control" id="txtGia" name="txtGia" placeholder="Giá loại xét nghiệm" value="<?php echo $row['gia'];?>"/>
                                                <label for="txtGia">Giá</label>
                                        </div>
                                    <div class="mt-4 mb-0">
                                    <input type="hidden" name="txtID" value="<?php echo $row['loai_id'];?>">
                                            <button class="btn-warning" style="float: right; margin-right: 600px" type="submit" >Cập nhật</button>
                                    </div>
                                </form>    
                            </div>
                        </div>
                    </div>
                </main>
                <footer class="py-4 bg-light mt-auto">
                    <div class="container-fluid px-4">
                        <div class="d-flex align-items-center justify-content-between small">
                           
                        </div>
                    </div>
                </footer>
            </div>
        </div>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="js/scripts.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/simple-datatables@latest" crossorigin="anonymous"></script>
        <script src="js/datatables-simple-demo.js"></script>
    </body>
</html>
