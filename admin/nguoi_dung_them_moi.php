<?php 
    // Mục đích kiểm tra xem bạn có quyền truy cập trang này không thông qua BIẾN $_SESSION['da_dang_nhap']
    session_start();
    if(isset($_SESSION['da_dang_nhap']) && $_SESSION['da_dang_nhap']==1 && $_SESSION['admin']==1)
{
?>
<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Thêm mới người dùng</title>
        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css" rel="stylesheet" />
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
        <script type="text/javascript">
      function validateForm()
      {
        var ten_nguoi_dung = document.forms["form_them_nv"]["txtTenNguoiDung"].value;
        var email = document.forms["form_them_nv"]["txtEmail"].value;
        var mat_khau = document.forms["form_them_nv"]["txtMatKhau"].value;
        
        if(ten_nguoi_dung.trim()=="")
        {
            alert("Bạn chưa nhập tên đăng nhập");
            document.forms["form_them_nv"]["txtTenNguoiDung"].focus();
            return false
        }

        if(mat_khau.trim()=="")
        {
            alert("Bạn chưa nhập mật khẩu");
            document.forms["form_them_nv"]["txtMatKhau"].focus();
            return false
        }

        if(email.trim()=="")
        {
            alert("Bạn chưa nhập số email");
            document.forms["form_them_nv"]["txtEmail"].focus();
            return false
        }

      }
    </script>
    </head>
    <body class="sb-nav-fixed">
        <?php
            include("simple-sidebar.php");
        ?>
            <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid px-4">
                        <h1 class="mt-4">Quản trị người dùng</h1>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item"><a href="index.php">Hệ thống</a></li>
                            <li class="breadcrumb-item active">Người dùng</li>
                        </ol>
                        <div class="card mb-4">
                            <div class="card-header">
                                <i class="fas fa-table me-1"></i>
                                Danh sách người dùng |<a href="nguoi_dung_them_moi.php"> Thêm mới</a>
                            </div>
                            <div class="card-body">
                                <form method="POST" action="nguoi_dung_them_moi_thuc_hien.php" id="form_them_nv" onsubmit="return(validateForm());" enctype="multipart/form-data">
                                    <div class="form-floating mb-3">
                                        <input class="form-control" id="txtTenNguoiDung" name="txtTenNguoiDung" placeholder="Tên người dùng" />
                                            <label for="txtTenNguoiDung">Tên người dùng</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <input class="form-control" id="txtEmail" name="txtEmail" placeholder="Email" />
                                            <label for="txtEmail">Email người dùng</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <input class="form-control" id="txtMatKhau" name="txtMatKhau" placeholder="Mật khẩu" />
                                            <label for="txtMatKhau">Mật khẩu</label>
                                    </div>
                                    <div class="form-group">
                                    <label class="control-label col-sm-2">Admin </label>
                                    <div class="col-sm-10">
                                    <select class="form-control" name="admin" id="admin">
                                    <option value="1">Quản lý</option>
                                    <option value="0">Nhân viên</option>                       
                                    </select>                     
                                    </div>
                                    </div>
                                    <div class="mt-4 mb-0">
                                        <div class="d-grid">
                                        <input class="btn btn-warning" type="submit" value="Lưu" /></div>
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
<?php    
}else{
    echo 
    "<script>
    alert('Bạn cần đăng nhập quyền admin để quản trị');
    window.location = 'dang_nhap.php';
    </script>";
}
?>