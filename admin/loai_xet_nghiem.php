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
        <title>Quản trị dịch vụ</title>
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
                        <h2 class="mt-4">QUẢN TRỊ DỊCH VỤ</h2>
                        
                        <div class="card mb-4">
                            <div class="card-header">
                                <div class="col-lg-12"><i class="fas fa-table me-1"></i>
                                DANH SÁCH CÁC LOẠI TEST/ XÉT NGHIỆM COVID-19 CỦA TRUNG TÂM
                                  <a class="btn btn-warning" href="../admin/loai_xet_nghiem_them_moi.php" style="float: right; margin-right: 14px">Thêm mới <i class="far fa-hand-point-right"></i></a>
                                </div>
                            </div>
                            <div class="card-body">
                                <table id="datatablesSimple">
                                    <thead>
                                        <tr>
                                            <th style="text-align: center; ">Mã loại</th>
                                            <th style="text-align: center; ">Ảnh</th>
                                            <th style="text-align: center; ">Tên loại</th>
                                            <th style="text-align: center; ">Mô tả</th>
                                            <th style="text-align: center; ">Giá</th>
                                            <th style="text-align: center; ">Thao tác</th>
                                        </tr>
                                    </thead>
                                    <tfoot>
                                        <tr>
                                           <th style="text-align: center; ">Mã loại</th>
                                            <th style="text-align: center; ">Ảnh</th>
                                            <th style="text-align: center; ">Tên loại</th>
                                            <th style="text-align: center; ">Mô tả</th>
                                            <th style="text-align: center; ">Giá</th>
                                            <th style="text-align: center; ">Thao tác</th>
                                        </tr>
                                    </tfoot>
                                    <tbody>
                                    <?php
                                
                                    include('config.php');
                                    $sql = "SELECT * FROM  tbl_loai_xet_nghiem 
                                        order by loai_id desc";                
                                    $ketquatruyvan  =mysqli_query($ket_noi,$sql);
                                   
                                    while($row = mysqli_fetch_array($ketquatruyvan)){                    
                                    ?>
                                    <tr>                            
                                    <td><?php echo $row['loai_id']; ?></td>
                                    <td style="text-align: center; "><img src="../images/<?php echo $row["anh_minh_hoa"];?>" style="width: 50px; height: auto;"></td>
                                    <td><?php echo $row['ten_loai']; ?></td>
                                    <td><?php echo $row['mo_ta']; ?></td>
                                    <td><?php echo number_format($row['gia'], 0, '', ',');?>đ</td>                            
                                    <td>
                                    <span><a class="btn btn-info" href="loai_xet_nghiem_sua.php?id=<?php echo $row['loai_id']; ?>">Sửa</a></span> 
                                                              
                                    <span><a class="btn btn-danger" href="loai_xet_nghiem_xoa.php?id=<?php echo $row['loai_id']; ?>">Xóa</a></span>
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
