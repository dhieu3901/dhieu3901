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
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item active"><b>Xét nghiệm </b></li>
                            <li class="breadcrumb-item"><a href="quan_tri_dich_vu.php"><b> Tư vấn</b></a></li> 
                        </ol> 
                        <div class="card mb-4">
                            <div class="card-header">
                                <div class="col-lg-12"><i class="fas fa-table me-1"></i>
                                DANH SÁCH ĐĂNG KÝ XÉT NGHIỆM COVID-19 
                                  <a class="btn btn-warning" href="../admin/loai_xet_nghiem.php" style="float: right; margin-right: 30px">Các loại hình xét nghiệm covid <i class="far fa-hand-point-right"></i></a>
                                </div>
                            </div>
                            <div class="card-body">
                                <table id="datatablesSimple">
                                    <thead>
                                        <tr>
                                            <th style="text-align: center; ">Mã KH</th>
                                            <th style="text-align: center; ">Tên người đăng kí</th>
                                            <th style="text-align: center; ">Email</th>
                                            <th style="text-align: center; ">Số điện thoại</th>
                                            <th style="text-align: center; ">Ngày xét nghiệm</th>
                                            <th style="text-align: center; ">Loại xét nghiệm</th>
                                            <th style="text-align: center; ">Tiền</th>
                                            <th style="text-align: center; ">Trạng thái thanh toán</th>
                                            <th style="text-align: center; ">Ngày thanh toán</th>
                                            <th style="text-align: center; ">Thao tác</th>
                                        </tr>
                                    </thead>
                                    <tfoot>
                                        <tr>
                                           <th style="text-align: center; ">Mã KH</th>
                                            <th style="text-align: center; ">Tên người đăng kí</th>
                                            
                                            <th style="text-align: center; ">Email</th>
                                            <th style="text-align: center; ">Số điện thoại</th>
                                            <th style="text-align: center; ">Ngày xét nghiệm</th>
                                            <th style="text-align: center; ">Loại xét nghiệm</th>
                                            <th style="text-align: center; ">Tiền</th>
                                            <th style="text-align: center; ">Trạng thái thanh toán</th>
                                            <th style="text-align: center; ">Ngày thanh toán</th>
                                            <th style="text-align: center; ">Thao tác</th>
                                        </tr>
                                    </tfoot>
                                    <tbody>
                                    <?php
                                
                                    include('config.php');
                                    $sql = "SELECT * FROM tbl_xet_nghiem join tbl_loai_xet_nghiem on tbl_xet_nghiem.loai_id=tbl_loai_xet_nghiem.loai_id
                                        order by xet_nghiem_id desc";                
                                    $ketquatruyvan  =mysqli_query($ket_noi,$sql);
                                   
                                    while($row = mysqli_fetch_array($ketquatruyvan)){                    
                                    ?>
                                        <tr>                            
                                            <td><?php echo $row['xet_nghiem_id']; ?></td>
                                            <td><?php echo $row['ten']; ?></td>
                                            <td><?php echo $row['email']; ?></td>
                                            <td><?php echo $row['sdt']; ?></td>
                                            <td><?php echo  date_format(new DateTime($row['ngay_xet_nghiem']),"d-m-Y");?></td>
                                            <td><?php echo $row['ten_loai']; ?></td>
                                            <td><?php echo number_format($row['so_tien'], 0, '', ',');?>đ</td>                            
                                            <?php if($row['tinh_trang_thanh_toan']==1){?>
                                            <td>Đã thanh toán</td>
                                            <?php } else { ?>
                                            <td>Chưa thanh toán</td> <?php } ?>                                                         
                                            <td><?php echo date_format(new DateTime($row['ngay_thanh_toan']),"d-m-Y"); ?></td>                                                 
                                            <td>
                                            <?php if($row['tinh_trang_thanh_toan']==0){
                                            ?>
                                                <a class="btn btn-info" href="xet_nghiem_xac_nhan.php?id=<?php echo $row['xet_nghiem_id']; ?>">Đã xét nghiệm</a>
                                            <?php 
                                            } ?>                            
                                                <a class="btn btn-danger" href="xet_nghiem_xoa.php?id=<?php echo $row['xet_nghiem_id']; ?>">Xóa</a>
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
