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
        <title>Quản trị tin tức</title>
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
                        <h2 class="mt-4">QUẢN TRỊ TIN TỨC</h2>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item"><a href="index.php"><b>Hệ thống</b></a></li>
                            <li class="breadcrumb-item active"><b>Tin tức</b></li>
                        </ol> 
                        <div class="card mb-4">
                            <div class="card-header">
                                <i class="fas fa-table me-1"></i>
                                DANH SÁCH TIN TỨC <a class="btn btn-warning" href="../admin/tin_tuc_them_moi.php" style="float: right; margin-right: 14px">Thêm mới tin tức  <i class="fas fa-plus-circle"></i></a>
                            </div>
                            <div class="card-body">
                                <table id="datatablesSimple">
                                    <thead>
                                        <tr>
                                            <th style="text-align: center; ">STT</th>
                                            <th style="text-align: center; ">Tiêu đề</th>
                                            <th style="text-align: center; ">Ảnh</th>
                                            <th style="text-align: center; ">Hashtag</th>
                                            <th style="text-align: center; ">Ngày đăng tin</th>
                                            <th style="text-align: center; ">Thao tác</th>
                                            
                                        </tr>
                                    </thead>
                                    <tfoot>
                                        <tr>
                                           <th style="text-align: center; ">STT</th>
                                            <th style="text-align: center; ">Tiêu đề</th>
                                            <th style="text-align: center; ">Ảnh</th>
                                            <th style="text-align: center; ">Hashtag</th>
                                            <th style="text-align: center; ">Ngày đăng tin</th>
                                            <th style="text-align: center; ">Thao tác</th> 
                                        </tr>
                                    </tfoot>
                                    <tbody>
                                    <?php
                                        include('config.php');

                                        $sql = "SELECT * 
                                                FROM tbl_tin_tuc   
                                                JOIN tbl_tin_tuc_hashtag 
                                                ON tbl_tin_tuc.hashtag_id=tbl_tin_tuc_hashtag.hashtag_id
                                                ORDER BY tin_tuc_id DESC";

                                      
                                        $noi_dung_tin_tuc=mysqli_query($ket_noi,$sql);

                                        $i=0;
                                        while ($row=mysqli_fetch_array($noi_dung_tin_tuc)) 
                                        {
                                            $i++;
                                    ;?>
                                        <tr>
                                            <td style="text-align: center; width: 30px"><?php echo $i;?></td>
                                            <td style="text-align: center; "><?php echo $row["tieu_de"];?></td>
                                            <td style="text-align: center; "><img src="../images/blog/blog-grid/<?php echo $row["anh_minh_hoa"];?>" style="width: 50px; height: auto;"></td>
                                            <td style="text-align: center; "><?php echo $row["ten_hashtag"];?></td>
                                            <td style="text-align: center; "><?php echo date_format(new DateTime($row["ngay_dang_tin"]),"d-m-Y");?></td>
                                            <td style="text-align: center; "><a class="btn btn-info" href="tin_tuc_sua.php?id=<?php echo $row['tin_tuc_id'];?>">Sửa</a>
                                            <span><a class="btn btn-danger" href="tin_tuc_xoa.php?id=<?php echo $row['tin_tuc_id'];?>" >Xóa</a></span></td>
                                            
                                           
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
