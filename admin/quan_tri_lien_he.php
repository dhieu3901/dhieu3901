<?php session_start();
if(isset($_SESSION['da_dang_nhap']) && $_SESSION['da_dang_nhap']==1)
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
        <title>Quản trị liên hệ</title>
        <link href="https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css" rel="stylesheet" />
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
    </head>
 <body class="sb-nav-fixed">	
        <!-- Sidebar -->
        <?php
        	include("simple-sidebar.php");
        ?>
        <!-- /#sidebar-wrapper -->

        <!-- Page Content -->
        <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid px-4">
                        <h2 class="mt-4">QUẢN TRỊ LIÊN HỆ</h2>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item"><a href="index.php"><b>Hệ thống</b></a></li>
                            <li class="breadcrumb-item active"><b>Liên hệ</b></li>
                        </ol>
                        <div class="card mb-4">
                            <div class="card-header">
                                <i class="fas fa-table me-1"></i>
                                Danh sách người liên hệ
                            </div>
                            <div class="card-body">
                                <table id="datatablesSimple">
            <?php
            include('config.php');

                $sql = "SELECT * FROM tbl_lien_he";
                $ketQuaTruyVan = mysqli_query($ket_noi,$sql);
            ?>
            <div class="container-fluid">
                <table class="table table-striped table-bordered">
                    <tr>
                        <th>Mã liên hệ</th>
                        <th>Họ tên</th>
                        <th>Số điện thoại</th>
                        <th>Email</th>
                        <th>Lời nhắn</th>
                        <th>Thao tác</th>            
                    </tr>
                    <?php
                    if($ketQuaTruyVan->num_rows > 0){
                    while($KH = mysqli_fetch_array($ketQuaTruyVan)){
                    ?>
                    <tr>
                		<td><?php echo $KH['contact_id']; ?></td>
                        <td><?php echo $KH['name']; ?></td>
                        <td><?php echo $KH['phone']; ?></td>
                        <td><?php echo $KH['email']; ?></td>
                        <td><?php echo $KH['message']; ?></td>      
                        <td>          
                        <a class="btn btn-danger" href="lien_he_xoa.php?id=<?php echo $KH['contact_id'];?>">Xóa</a>
                        </td>
                    </tr>    
                <?php               
                }
                }
                ?>
                </table>                      
            </div>               
        </div>
    </div>
        <!-- /#page-content-wrapper -->

    </div>
    <!-- /#wrapper -->

    <!-- jQuery -->
    <script src="../js/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="../js/bootstrap.min.js"></script>

    <!-- Menu Toggle Script -->
    
</body>
</html>
<?php    
}else{
    echo 
    "<script>
    alert('Bạn cần đăng nhập để quản trị');
    window.location = 'index.php';
    </script>";
}
?>