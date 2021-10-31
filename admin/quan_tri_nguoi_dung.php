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
        <title>Quản trị người dùng</title>
        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css" rel="stylesheet" />
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
        
    </head>
    <body class="sb-nav-fixed">
        <?php
            include("simple-sidebar.php");
        ?>
            <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid px-4">
                        <h2 class="mt-4">QUẢN TRỊ NGƯỜI DÙNG</h2>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item"><a href="index.php"><b>Hệ thống</b></a></li>
                            <li class="breadcrumb-item active"><b>Người dùng</b></li>
                        </ol>
                        <div class="card mb-4">
                            <div class="col-lg-12">
                        <a class="btn btn-warning" href="../admin/nguoi_dung_them_moi.php" style="float: left; margin-right: 14px">Thêm quản trị viên  <i class="fas fa-user-plus"></i></a>
                    </div>
                            <div class="card-body">
                                <table id="datatablesSimple">
                                    <thead>
                                        <tr>
                                            <th style="text-align: center; ">STT</th>
                                            <th style="text-align: center; ">Tên đăng nhập</th>
                                            <th style="text-align: center; ">Email</th>
                                             <th style="text-align: center; ">Mật khẩu</th>
                                            <th style="text-align: center; ">Last login</th>
                                            <th style="text-align: center; ">Admin</th>
                                            <th style="text-align: center; ">Thao tác</th>
                                            
                                        </tr>
                                    </thead>
                                    <tbody>
                                    <?php
                                        include('config.php');

                                        $sql="SELECT * FROM tbl_nguoi_dung 
                                                order by nguoi_dung_id desc";

                                      
                                        $noi_dung_nguoi_dung=mysqli_query($ket_noi,$sql);

                                        $i=0;
                                        while ($row=mysqli_fetch_array($noi_dung_nguoi_dung)) 
                                        {
                                            $i++;
                                    ;?>
                                        <tr>
                                            <td style="text-align: center; "><?php echo $i;?></td>
                                            <td style="text-align: center; "><?php echo $row["ten_nguoi_dung"];?></td>
                                            <td style="text-align: center; "><?php echo $row["email"]?></td>
                                            <td style="text-align: center; "><?php echo $row["mat_khau"]?></td>
                                            <td><?php echo date_format(new DateTime($row["last_login"]),"d-m-Y"); ?></td>
                                            <?php if($row['admin']==1){?>
                                                <td>Có</td>
                                                <?php } else { ?>
                                                <td>Không</td> <?php } ?>
                                           <td>
                                            <a class="btn btn-info" href="nguoi_dung_sua.php?id=<?php echo $row['nguoi_dung_id'];?>">Sửa</a>
                                            <span><a class="btn btn-danger" href="nguoi_dung_xoa.php?id=<?php echo $row['nguoi_dung_id'];?>" >Xóa</a></span>
                                        </td>
                                    </tr>
                                    <?php
                                    }
                                        mysqli_close($ket_noi);
                                    ;?>
                                    </tbody>
                                </table>
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