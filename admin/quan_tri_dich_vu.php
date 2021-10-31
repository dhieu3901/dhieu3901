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
                            <li class="breadcrumb-item"><a href="quan_tri_xet_nghiem.php"><b>Xét nghiệm </b></a></li>
                            <li class="breadcrumb-item active"><b> Tư vấn</b></li>
                        </ol> 
                        <div class="card mb-4">
                            <div class="card-header">
                                <i class="fas fa-table me-1"></i>
                                Danh sách người đăng kí tư vấn 
                            </div>
                            <div class="card-body">
                                <table id="datatablesSimple">
                                    <thead>
                                        <tr>
                                            <th style="text-align: center; ">STT</th>
                                            <th style="text-align: center; ">Tên người đăng kí</th>
                                            
                                            <th style="text-align: center; ">Email</th>
                                            <th style="text-align: center; ">Số điện thoại</th>
                                            <th style="text-align: center; ">Phương thức</th>
                                            <th style="text-align: center; ">Ngày đặt lịch</th>
                                            <th style="text-align: center; ">Thao tác</th>
                                        </tr>
                                    </thead>
                                    <tfoot>
                                        <tr>
                                           <th style="text-align: center; ">STT</th>
                                            <th style="text-align: center; ">Tên người đăng kí</th>
                                            
                                            <th style="text-align: center; ">Email</th>
                                            <th style="text-align: center; ">Số điện thoại</th>
                                            <th style="text-align: center; ">Ngày đặt lịch</th>
                                            <th style="text-align: center; ">Phương thức</th>
                                            <th style="text-align: center; ">Thao tác</th>
                                        </tr>
                                    </tfoot>
                                    <tbody>
                                    <?php
                                        include('config.php');

                                        $sql = "SELECT * 
                                                FROM tbl_tu_van   
                                                ";

                                        $noi_dung=mysqli_query($ket_noi,$sql);
                                        //echo $noi_dung_tin_tuc;
                                        $i=0;
                                        while ($row=mysqli_fetch_array($noi_dung)) 
                                        {
                                            $i++;
                                    ;?>
                                        <tr>
                                            <td style="text-align: center; width: 30px"><?php echo $i;?></td>
                                            <td style="text-align: center; "><?php echo $row["ho_ten"];?></td>
                                            
                                            
                                            <td style="text-align: center; "><?php echo $row["email"];?></td>
                                             <td style="text-align: center; "><?php echo $row["sdt"];?></td>

                                            <?php if($row['phuong_thuc']=='Gọi điện thoại'){?>
                                            <td>Gọi điện thoại</td>
                                            <?php } elseif($row['phuong_thuc']=='Qua video') { ?>
                                            <td>Qua video</td>
                                            <?php } else {?> 
                                            <td>Nhắn tin trao đổi</td> <?php } ?>
                                            
                                            <td><?php echo date_format(new DateTime($row['ngay_tu_van']),"d-m-Y"); ?></td>                     
                                            <td style="text-align: center; ">
                                            <span><a class="btn btn-danger" href="tu_van_xoa.php?id=<?php echo $row['tu_van_id'];?>" >Xóa</a></span></td>
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
