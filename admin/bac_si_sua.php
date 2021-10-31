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
            include("simple-sidebar.php");
        ?>
            <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid px-4">
                        <h1 class="mt-4">Quản trị bác sĩ</h1>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item"><a href="index.php">Hệ thống</a></li>
                            <li class="breadcrumb-item active">Bác Sĩ</li>
                        </ol>
                        <div class="card mb-4">
                            <div class="card-header">
                                <i class="fas fa-table me-1"></i>
                                Danh sách bác sĩ |<a href="bac_si_them_moi.php"> Thêm mới</a>
                            </div>
                            <div class="card-body">
                            <?php
                            
                            //1. 1. Kết nối đến MÁY CHỦ DỮ LIỆU & ĐẾN CSDL 
                            include('config.php');
                            // 2. Viết câu lệnh truy vấn để lấy ra được DỮ LIỆU MONG MUỐN (TIN TỨC đã lưu trong CSDL)
                            $bac_si_id=$_GET["id"];

                            $sql="SELECT * 
                                    FROM tbl_bac_si
                                    WHERE bac_si_id= ".$bac_si_id."
                                    ORDER BY  bac_si_id DESC";
                            // 3. Thực thi câu lệnh truy vấn (mục đích trả về dữ liệu các bạn cần)
                            $noi_dung_bac_si=mysqli_query($ket_noi,$sql);
                            //4.
                            $row = mysqli_fetch_array($noi_dung_bac_si);
                                       
                            ;?>
                                <form method="POST" action="bac_si_sua_thuc_hien.php" enctype="multipart/form-data">
                                    <div class="form-floating mb-3">
                                        <input class="form-control" id="txtTen" name="txtTen" placeholder="Tên Bác sĩ" value="<?php echo $row['ten_bac_si'];?>" />
                                            <label for="txtTen">Tên Bác Sĩ</label>
                                    </div>

                                    <div class="form-floating mb-3">
                                            <input type="file" class="form-control"  name="txtAnhMinhHoa" id="txtAnhMinhHoa"  value="<?php echo $row['anh_minh_hoa']; ?>" />
                                                <label for="txtAnhMinhHoa">Ảnh minh họa</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                         <textarea class="form-control" id="txtChucVu" name="txtChucVu" placeholder="Chức Vụ"><?php echo $row['chuc_vu'];?></textarea>
                                            <label for="txtChucVu">Chức Vụ</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                         <textarea class="form-control" id="txtGhiChu" name="txtGhiChu" placeholder="Ghi chú"><?php echo $row['ghi_chu'];?></textarea>
                                            <label for="txtGhiChu">Ghi chú</label>
                                    </div>
                                    <div class="mt-4 mb-0">
                                    <input type="hidden" name="txtID" value="<?php echo $row['bac_si_id'];?>">
                                        <div class="d-grid"><button type="submit" >Cập nhật</button></div>
                                    </div>
                                </form>    
                            </div>
                        </div>
                    </div>
                </main>
                <footer class="py-4 bg-light mt-auto">
                    <div class="container-fluid px-4">
                        <div class="d-flex align-items-center justify-content-between small">
                            <div class="text-muted">Copyright &copy; Your Website 2021</div>
                           
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
