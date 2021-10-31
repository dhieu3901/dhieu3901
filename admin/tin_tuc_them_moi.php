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
        <title>Thêm mới tin tức</title>
        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css" rel="stylesheet" />
        <link href="css/styles.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
        <script src="https://cdn.tiny.cloud/1/iicm9hnap8lvqc02ax8srkjk3oi7ba2eulhp0walx01iwu7q/tinymce/5/tinymce.min.js" referrerpolicy="origin"></script>
        <script src="/path/to/tinymce.min.js"></script>
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
                        <h1 class="mt-4">Quản trị tin tức</h1>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item"><a href="index.php">Hệ thống</a></li>
                            <li class="breadcrumb-item active">Tin tức</li>
                        </ol>
                        <div class="card mb-4">
                            <div class="card-header">
                                <i class="fas fa-table me-1"></i>
                                THÊM MỚI TIN TỨC  <a class="btn btn-info" href="quan_tri_tin_tuc.php" style="float: right; margin-right: 14px"> Trở lại</a>
                            </div>
                            <div class="card-body">
                                <form method="POST" action="tin_tuc_them_moi_thuc_hien.php" enctype="multipart/form-data">
                                    <div class="form-floating mb-3">
                                        <input class="form-control" id="txtTieuDe" name="txtTieuDe" placeholder="Tiêu đề bài viết" required/>
                                            <label for="txtTieuDe">Tiêu đề bài viết</label>
                                    </div>
                                    
                                        <div class="form-floating mb-3">
                                            <input type="file" class="form-control" id="txtAnhMinhHoa" name="txtAnhMinhHoa"  />
                                                <label for="txtAnhMinhHoa">Ảnh minh họa</label>
                                        </div>
                                    <div class="form-floating mb-3" >
                                        <h5>Chọn hashtag</h5>
                                         <select  name="txtHashtag" id="txtHashtag" placeholder="Chọn hashtag" >
                                       
                                        <?php  
                                            include('config.php');
                                            $sql= "SELECT * FROM tbl_tin_tuc_hashtag";
                                        $noi_dung_tin_tuc=mysqli_query($ket_noi,$sql);

                                        while ($row=mysqli_fetch_array($noi_dung_tin_tuc)) 
                                        {
                                        ;?>
                                            <option value="<?php echo $row["hashtag_id"];?>"><?php echo $row["ten_hashtag"];?></option>
                                        <?php
                                        }
                                        ;?>
                                        </select>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <textarea placeholder="Mô tả bài viết" name="txtMoTa"  id="txtMoTa"></textarea>
                                            <label for="txtMoTa">Mô tả bài viết</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <textarea placeholder="Nội dung bài viết"  name="txtNoiDung" id="txtNoiDung" ></textarea>
                                            <label for="txtNoiDung">Nội dung bài viết</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <input class="form-control" id="txtTacGia" name="txtTacGia" placeholder="Tác giả bài viết" required/>
                                            <label for="txtTacGia">Tác giả bài viết</label>
                                    </div>
                                    </div>
                                    
                                    </div>
                                    <div class="col-md-6">
                                    <div class="form-floating mb-3">
                                        <input type="date" class="form-control" id="txtNgayDangTin" name="txtNgayDangTin" placeholder="Chọn ngày đăng tin" required/>
                                            <label for="txtNgayDangTin">Ngày đăng tin</label>
                                    </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating mb-3">
                                            <input class="form-control" id="txtSoLanDoc" name="txtSoLanDoc" placeholder="Số lần đọc" required/>
                                                <label for="txtSoLanDoc">Số lần đọc</label>
                                        </div>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <input class="form-control" id="txtGhiChu" name="txtGhiChu" placeholder="Ghi chú" />
                                            <label for="txtGhiChu">Ghi chú</label>
                                    </div>            
                                    <div class="mt-4 mb-0">
                                        <button class="btn-warning" type="submit">Đăng bài</button>
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
