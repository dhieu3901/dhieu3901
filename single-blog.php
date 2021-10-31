<?php 
    session_start();
    include('config.php');
    $tin_tuc_id = $_GET['id'];
    $sql1= "SELECT * FROM tbl_tin_tuc 
          WHERE `tbl_tin_tuc`.`tin_tuc_id` = '".$tin_tuc_id."'";
    $truy_cap= mysqli_fetch_array(mysqli_query($ket_noi,$sql1));
    $_SESSION['luotdoc']= $truy_cap['so_lan_doc'];
    if(isset($_SESSION['luotdoc']))
    $_SESSION['luotdoc']+=1;
    $sql2 = "UPDATE `tbl_tin_tuc` SET so_lan_doc = '".$_SESSION['luotdoc']."' WHERE tbl_tin_tuc.tin_tuc_id = '".$tin_tuc_id."'" ;  
    $lan_doc = mysqli_query($ket_noi, $sql2);
    mysqli_close($ket_noi);
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <!-- Required meta tags -->
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="icon" href="images/favicon.png" type="image/png" />
    <title>COVID - 19</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="vendors/fontawesome/css/all.css" />
    <link rel="stylesheet" href="vendors/animate-css/animate.css" />
    <link rel="stylesheet" href="vendors/linearicons/css/linearicons.css" />
    <link rel="stylesheet" href="vendors/slick/slick.css" />
    <link rel="stylesheet" href="vendors/slick/slick-theme.css" />
    <link rel="stylesheet" href="vendors/mCustomScrollbar/jquery.mCustomScrollbar.min.css" />

    <!-- main css -->
    <link rel="stylesheet" href="css/style.css" />
    <link rel="stylesheet" href="css/responsive.css" />

    <style type="text/css">
      .addnew img:hover{
        opacity: 0.5;
        transition:0.5s;
      }
      .addnew a:hover{
        transition:0.5s;
      }
    </style>

</head>

<body data-scroll-animation="true">
    <div class="body_wrapper">

        <!--================Preloader Area =================-->
        <div class="preloader">
          <div class="three-bounce">
            <div class="one"></div>
            <div class="two"></div>
            <div class="three"></div>
          </div>
        </div>
        <!--================End Preloader Area =================-->
    <!--================Mobile Canvus Menu Area =================-->
    <div class="mobile_canvus_menu">
      <div class="close_btn">
        <img src="images/icon/close-dark.png" alt="">
      </div>
      <div class="menu_part_lux">
        <ul class="menu_list wd_scroll">
          <li><a href="index.php">Trang chủ</a></li>
          <li>
            <a href="index.php">Phòng chống
              <i class="linearicons-chevron-down"></i>
            </a>
            <ul class="list">
              <li><a href="symptom.php">Các triệu chứng thường gặp</a></li>
              <li><a href="symptom-checker.php">Kiểm tra triệu chứng</a></li>
              <li><a href="prevention.php">Biện pháp phòng chống</a></li>
              <li><a href="tracker.php">Bản đồ dịch tễ Hà Nội</a></li>
            </ul>
          </li>
          <li><a href="appointment.php">Tư vấn</a></li>
          <li>
            <a href="#">Giới thiệu
              <i class="linearicons-chevron-down"></i>
            </a>
            <ul class="list">
              <li><a href="coronavirus.php">Corona Virus</a></li>
              <li><a href="doctors.php">Đội ngũ bác sĩ</a></li>
              <li><a href="vaccine.php">Tin tức</a></li>
            </ul>
          </li>
          <li>
            <a href="blog.php">Tin tức</a>
          </li>
          <li>
            <a href="contact.php">Liên hệ</a>
          </li>
        </ul>
      </div>
      <div class="menu_btm">
        <a class="green_btn" href="symptom-checker.php"><i class="linearicons-pulse"></i>Đăng Ký Test COVID</a>
      </div>
    </div>
    <!--================End Mobile Canvus Menu Area =================-->
    <!--================Sidebar Form Area =================-->
    <div class="body_capture"></div>
    <section class="sidebar_widget scroll_body">
      <div class="info_sidebar_inner">
        <div class="close_btn">
          <img src="images/icon/close.png" alt="">
        </div>
        <ul class="nav info_social">
          <li>
            <a href="#"><i class="fab fa-facebook"></i></a>
          </li>
          <li>
            <a href="#"><i class="fab fa-twitter"></i></a>
          </li>
          <li>
            <a href="#"><i class="fab fa-instagram"></i></a>
          </li>
          <li>
            <a href="#"><i class="fab fa-youtube"></i></a>
          </li>
          <li>
            <a href="#"><i class="fab fa-vimeo-v"></i></a>
          </li>
        </ul>
        <div class="info_title">
          <h2>Liên Hệ</h2>
          <p>Nếu bạn có bất kỳ câu hỏi nào trước khi chúng tôi bắt đầu, vui lòng điền vào bên dưới biểu mẫu liên hệ.</p>
        </div>
        <form action="#" class="appoinment_form js-form">
          <div class="row">
            <div class="col-lg-12">
              <div class="form-group">
                <input class="form-control" type="text" id="a_name" name="a_name" placeholder="" required />
                <label><i class="linearicons-user"></i>Họ và tên</label>
              </div>
            </div>
            <div class="col-lg-12">
              <div class="form-group">
                <input class="form-control" type="text" id="a_email" name="a_email" placeholder="" required />
                <label><i class="linearicons-envelope-open"></i> Email
                  </label>
              </div>
            </div>
            <div class="col-lg-12">
              <div class="form-group">
                <input class="form-control" type="text" id="a_number" name="a_number" placeholder="" required />
                <label><i class="linearicons-telephone"></i>Số điện thoại</label>
              </div>
            </div>
            <div class="col-lg-12">
              <div class="form-group">
                <textarea name="a_message" id="a_message" cols="30" rows="10" class="form-control" required></textarea>
                <label><i class="linearicons-document"></i>Nội dung</label>
              </div>
            </div>
            <div class="col-lg-12">
              <div class="form-group checkbox_field">
                <div class="checkbox">
                  <input type="checkbox" value="None" id="a_policy" name="check" />
                 <label class="l_text" for="squared2">Tôi chấp nhận <span>Chính sách bảo mật</span></label>
                </div>
                <button type="submit" class="green_btn" name="appoinment" id="appoinment" value="appoinment"
                  data-value="appoinment">
                  Gửi
                </button>
              </div>
            </div>
          </div>
          <div class="success-message">
            <i class="fa fa-check text-primary"></i> Cảm ơn bạn!. Tin nhắn của bạn đã được gửi thành công...
          </div>
          <div class="error-message">Chúng tôi xin lỗi! Bạn đã nhập sai cú pháp</div>
        </form>
        <div class="info_footer">
           <p>© Bản quyền
            <script>
              document.write(new Date().getFullYear());
            </script> HALN PC-Covid.
          </p>     
        </div>
      </div>
    </section>
    <!--================End Sidebar Form Area =================-->

    <!--================Header Area =================-->
    <header class="header_area">
      <ul class="nav menu_social flex-column">
        <li>
          <a href="#"><i class="fab fa-facebook"></i></a>
        </li>
        <li>
          <a href="#"><i class="fab fa-twitter"></i></a>
        </li>
        <li>
          <a href="#"><i class="fab fa-instagram"></i></a>
        </li>
      </ul>
      <div class="main_menu">
        <div class="container">
          <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <a class="navbar-brand" href="index.php"><img src="images/logoo.png"
                srcset="images/logo-2xx.png 2x" alt="" /></a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent"
              aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="nav navbar-nav ml-auto">
                <li><a href="index.php ">Trang chủ</a></li>
                  <li class="dropdown submenu">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="prevention.php" role="button"
                       aria-haspopup="true" aria-expanded="false">Phòng chống </a>
                      <i class="fas fa-angle-down" aria-hidden="true" data-toggle="dropdown"></i>                                  
                        <ul class="dropdown-menu">
                          <li><a href="symptom.php">Các triệu chứng phổ biến</a></li>
                          <li><a href="symptom-checker.php">Đăng Ký Test COVID</a></li>
                          <li><a href="prevention.php">Biện pháp phòng chống</a></li>
                          <li><a href="tracker.php">Bản đồ dịch tễ Hà Nội</a></li>
                        </ul>                         
                  </li>
                <li><a href="appointment.php">Tư vấn</a></li>
                <li class="dropdown submenu">
                  <a class="dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true"
                    aria-expanded="false">Giới thiệu</a>
                  <i class="fas fa-angle-down" aria-hidden="true" data-toggle="dropdown"></i>
                  <ul class="dropdown-menu">
                    <li><a href="coronavirus.php">Corona Virus</a></li>
                    <li><a href="doctors.php">Đội ngũ bác sĩ</a></li>
                    <li><a href="vaccine.php">Vaccien Phòng COVID-19 </a></li>
                  </ul>
                </li>
                <li class="active">
                  <a href="blog.php">Tin tức</a>
                </li>
                <li>
                  <a href="contact.php">Liên hệ</a>
                </li>
              </ul>
              <ul class="nav navbar-nav navbar-right">
                <li class="checker_btn">
                  <a href="symptom-checker.php"></i>Đăng Ký Test COVID</a>
                </li>
              </ul>
            </div>
          </nav>
        </div>
        <div class="right_burger">
          <ul class="nav">
            <li>
              <div class="search_btn" data-toggle="modal" data-target="#exampleModal">
                <img src="images/icon/search.png" alt="" />
              </div>
            </li>
            <li>
              <div class="menu_btn">
                <img src="images/icon/burger.png" alt="" />
              </div>
            </li>
          </ul>
        </div>
      </div>
    </header>
    <!--================End Header Area =================-->
        <!--================Breadcrumb Area =================-->
        <section class="breadcrumb_area">
            <div class="container">
                <div class="breadcrumb_text">
                    <h6 class="wow fadeInUp">Trung tâm y tế quận Hoàn Kiếm</h6>
                    <h3 class="wow fadeInUp" data-wow-delay="0.2s">Tin tức mới nhất</h3>
                    <ul class="nav justify-content-center wow fadeInUp" data-wow-delay="0.3s">
                        <li><a href="index.php">Trang chủ</a></li>
                        <li><a href="blog.php">Tin tức</a></li>
                    </ul>
                </div>
            </div>
        </section>
        <!--================End Breadcrumb Area =================-->

        <!--================Single Blog Content Area =================-->
        <section class="single_blog_area">
            <div class="container">
                <div class="row single_blog_inner">
                <?php 
                    // 1. Load file cấu hình để kết nối đến máy chủ CSDL, CSDL
                    include('config.php');

                    // 2. Viết câu lệnh truy vấn để lấy ra được DỮ LIỆU MONG MUỐN (TIN TỨC đã lưu trong CSDL)
                   $id_tin = $_GET["id"];
                    
                    $sql = " SELECT * 
                            FROM tbl_tin_tuc, tbl_chu_de
                            where tbl_tin_tuc.chu_de_id= tbl_chu_de.chu_de_id and tbl_tin_tuc.tin_tuc_id=".$id_tin." ORDER BY  tbl_tin_tuc.chu_de_id DESC";

                    // 3. Thực thi câu lệnh truy vấn (mục đích trả về dữ liệu các bạn cần)
                    $noi_dung_tin_tuc = mysqli_query($ket_noi, $sql);

                    // 4. Hiển thị ra dữ liệu mà các bạn vừa lấy được
                    $row = mysqli_fetch_array($noi_dung_tin_tuc);
                     ?>
                        <div class="col-lg-9">
                        <div class="single_blog_text_inner">
                            <div class="single_first_text">
                                <h1><?php echo $row["tieu_de"];?></h1>
                                <div class="media">
                                    <div class="media-body">
                                        <h4><i> <?php echo $row["mo_ta"];?></i></h4>
                                    </div>
                                </div>
                                
                            </div>
                            <div class="secand_part">
                                
                                <p><?php echo $row["noi_dung"]; ?></p></br>
                                
                            </div>
                             <div>   
                                <img class="img-fluid" src="<?php echo $row['anh_minh_hoa'] ? 'images/blog/blog-grid/'.$row['anh_minh_hoa'] :'images/blog/blog-grid/blog-1.jpeg';?>" alt="" />
                            </div>
                            
                            <div class="single_blog_bottom">
                                <div class="row m-0 justify-content-between">
                                    <div class="left">
                                        
                                    </div>
                                    <div class="right">
                                        <ul class="nav">
                                            <li><a href="#"><i class="fab fa-facebook"></i></a></li>
                                            <li><a href="#"><i class="fab fa-twitter"></i></a></li>
                                            <li><a href="#"><i class="fab fa-pinterest"></i></a></li>
                                            <li><a href="#"><i class="fab fa-linkedin"></i></a></li>
                                            <li><a href="#"><i class="fas fa-envelope-open-text"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <hr width="100%"
                                color="#58547e"
                                size="5px">
                            <div class="post_author">
                                <div class="media media-img">
                                    <div class="d-flex">

                                        <img style="width: 150px; height: 150px;"
                                        class="rounded-circle" src="images/author.jpg" alt="">
                                    </div>

                                    <div class="media-body">
                                        <br>
                                        <h4>GS.TS Phan Trọng Lân</h4>
                                        <h6>Viện trưởng Viện Pasteur TP.HCM</h6>
                                        <p>Để dự phòng và kiểm soát bệnh truyền nhiễm lây qua đường hô hấp, cần tập trung vào 3 mắc xích: Một là nguồn lây nhiễm, hai là đường lây truyền, ba là người cảm nhiễm. Nếu mắt xích nào chưa đảm bảo thì phải nỗ lực nhiều hơn nữa những mắc xích còn lại.<br><br>
                                        Mỗi người dân cần ý thức được tầm quan trọng của việc hạn chế các hành vi nguy cơ này. Nếu mỗi người dân đều thực hiện nghiêm quy tắc 5K: Đeo Khẩu trang – Khử khuẩn – Giữ Khoảng cách an toàn – Không tập trung – Khai báo y tế thì cho dù là biến thể nào của SARS-CoV-2 cũng khó có khả năng lây lan.
                                        </p>
                                    </div>
                                </div>
                            </div>

                            <div class="comment_box">
                                
                                  
                                </form>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="right_sidebar">
                           <!-- <aside class="right_widget ct_widget">
                                <div class="r_wd_title">
                                    <h3>Tổng hợp</h3>
                                </div>
                                <?php
                            // 1. Load file cấu hình để kết nối đến máy chủ CSDL, CSDL
                            $ket_noi = mysqli_connect("localhost","root","","btl_db");

                            // 2. Viết câu lệnh truy vấn để lấy ra được DỮ LIỆU MONG MUỐN (TIN TỨC đã lưu trong CSDL)
                                $sql = " SELECT * FROM tbl_chu_de ";
                            // 3. Thực thi câu lệnh truy vấn (mục đích trả về dữ liệu các bạn cần)
                                $noi_dung_tin_tuc = mysqli_query($ket_noi, $sql);

                             // 4. Hiển thị ra dữ liệu mà các bạn vừa lấy được
                             while ($row = mysqli_fetch_array($noi_dung_tin_tuc)) 

                            {
                             ;?>
                             <ul class="nav flex-column">
                             <li><a href="#"><i class="fas fa-arrow-right"></i><?php echo $row["chu_de"];?>
                                            <span></span></a></li>
                            </ul>
                            <?php 
                             }

                            // 5. Đóng kết nối sau khi sử dụng xong
                            mysqli_close($ket_noi);
                        ;?>-->
                                
                            </aside>
                            <aside class="right_widget subs_widget">
                                <img src="images/subscribe-widget-bg.jpg" alt="">
                                <div class="subs_text">
                                    <i class="linearicons-envelope-open"></i>
                                    <h4>Cập nhật</h4>
                                    <p>Theo dõi chúng tôi trên Facebook để cập nhật những tin tức mới nhất về COVID-19</p>
                                    <a class="subs_btn" href="https://www.facebook.com/trungtamytequanhoankiem36ngoquyen">Theo dõi</a>
                                </div>
                            </aside>
                            <aside class="right_widget wash_widget">
                                <h6>Quy trình rửa tay</h6>
                                <h3>Các bước rửa tay theo tiêu chuẩn của Bộ Y Tế</h3>
                                <p>Ngày nay, tất cả mọi người đều phải cần có thói quen rửa tay, thậm chí các em nhỏ, ngay từ bậc mẫu giáo đã được giáo dục rất kỹ về các bước rửa tay - một công việc tưởng chừng đơn giản nhưng lại mang lại rất nhiều lợi ích. Vậy tại sao chúng ta phải rửa tay và rửa tay như thế nào cho đúng?
                                </p>
                                <a class="text_btn" href="index.php">Xem thêm <i class="fas fa-arrow-right"></i></a>
                            </aside>
                            <aside class="right_widget tag_widget">
                                <div class="r_wd_title">
                                    <h3>Tags</h3>
                                </div>
                    
                        <ul class="nav">
                                    <li><a >Vaccine</a></li>
                                    <li><a>Corona Virus</a></li>
                                    <li><a>covid-19</a></li>
                                    <li><a>Astra Zeneca</a></li>
                                    <li><a>Pfizer</a></li>
                                    <li><a>F0</a></li>
                                    <li><a>Cách ly</a></li>
                                </ul>
                    
                                
                            </aside>
                            
                            
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--================End Single Blog Content Area =================-->

        <!--================Related Post Area =================-->
        <section class="related_posts_area">
            <div class="container">
                <div class="main_title text-center">
                    <h5>Bài viết gần đây</h5>
                    <h2>Có thể bạn quan tâm</h2>
                </div>
                <div class="row related_post_inner">
                 <?php 
                    // 1. Load file cấu hình để kết nối đến máy chủ CSDL, CSDL
                    $ket_noi = mysqli_connect("localhost","root","","btl_db");
                    // 2. Viết câu lệnh truy vấn để lấy ra được DỮ LIỆU MONG MUỐN (TIN TỨC đã lưu trong CSDL)
                    $sql = " SELECT * 
                             FROM tbl_tin_tuc, tbl_chu_de
                              where tbl_tin_tuc.chu_de_id= tbl_chu_de.chu_de_id ORDER BY tbl_tin_tuc.chu_de_id DESC LIMIT 3";
                    // 3. Thực thi câu lệnh truy vấn (mục đích trả về dữ liệu các bạn cần)
                    $noi_dung_tin_tuc = mysqli_query($ket_noi, $sql);

                    // 4. Hiển thị ra dữ liệu mà các bạn vừa lấy được
                    while ($row = mysqli_fetch_array($noi_dung_tin_tuc)) 
                    {
                    ;?>
                    <div class="col-lg-4 col-md-6">
                        <div class="small_l_blog_item">
                            <div class="l_blog_img">
                                <img style="width: 370px; height: 200px;"  
                                class="img-fluid" src="<?php echo $row['anh_minh_hoa'] ? 'images/blog/blog-grid/'.$row['anh_minh_hoa'] :'images/blog/blog-grid/blog-1.jpeg';?>" alt="">
                            </div>
                            <div class="l_blog_text">
                                <div class="date">
                                <a><?php echo date("d/m/Y H:i", strtotime($row["ngay_dang_tin"]));?></a>
                                    <a><?php echo $row["so_lan_doc"];?> lượt đọc</a>
                                </div>
                               <a href="single-blog.php?id=<?php echo $row['tin_tuc_id'];?>">
                                        <h3 style="font-size: 13px; max-width: 210px;"><?php echo $row["tieu_de"] ;?></h3>
                                    </a>
                                    <a class="text_btn" href="single-blog.php?id=<?php echo $row['tin_tuc_id'];?>">Đọc thêm 
                                    <i class="fas fa-arrow-right"></i></a>
                            </div>
                        </div>
                    </div>
                        <?php 
                    }

                    // 5. Đóng kết nối sau khi sử dụng xong
                    mysqli_close($ket_noi);
                ;?>

            </div>
        </section>
        <!--================End Related Post Area =================-->


    <!--================App Area =================-->
    <section class="app_area">
      <div class="container">
        <div class="row">
          <div class="col-lg-6">
            <div class="app_text">
              <h2>Tải ứng dụng <span>PC Covid</span></h2>
              <p>
                Tải xuống ứng dụng của chúng tôi ngay bây giờ, theo dõi các trường hợp Coronavirus trong thời gian thực và theo dõi các bản cập nhật tức thì.
              </p>
              <a href="https://apps.apple.com/vn/app/pc-covid-viet-nam/id1508062685"><img src="images/apple-btn.png" alt="" /></a>
              <a href="https://play.google.com/store/apps/details?id=com.mic.bluezone&hl=vi&gl=US"><img src="images/google-btn.png" alt="" /></a>
            </div>
          </div>
          <div class="col-lg-6">
            <div class="app_mobile">
              <div class="mobile_image">
                <img src="images/mobile-11.png" alt="" />
                <img class="wow fadeInUp" data-wow-delay="400ms" src="images/mobile-22.png" alt="" />
              </div>
              <ul class="corona_img nav">
                <li>
                  <img src="images/icon/app-virus-1.png" alt="" />
                </li>
                <li>
                  <img src="images/icon/app-virus-2.png" alt="" />
                </li>
                <li>
                  <img src="images/icon/app-virus-3.png" alt="" />
                </li>
                <li>
                  <img src="images/icon/app-virus-4.png" alt="" />
                </li>
                <li data-parallax='{"y": 100}'>
                  <img src="images/icon/app-virus-5.png" alt="" />
                </li>
                <li>
                  <img src="images/icon/app-virus-6.png" alt="" />
                </li>
                <li>
                  <img src="images/icon/app-virus-7.png" alt="" />
                </li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </section>
    <!--================End App Area =================-->

    <!--================Subscribe Area =================-->
    <section class="subscribe_area apps_craft_animation">
      <ul class="nav">
        <li><img class="layer layer2" data-depth="0.5" src="images/icon/subs-1.png" alt=""></li>
        <li><img src="images/icon/subs-2.png" alt=""></li>
        <li><img src="images/icon/subs-3.png" alt=""></li>
      </ul>
      <div class="container">
        <div class="row">
          <div class="col-lg-6">
            <div class="media">
              <div class="d-flex">
                <i class="linearicons-mailbox-full"></i>
              </div>
              <div class="media-body">
                <h4>Đăng kí nhận tin tức</h4>
                <p>
                  Tham gia danh sách người nhận tin tức của chúng tôi để nhận tin tức COVID-19 được gửi qua Email của bạn</p>
              </div>
            </div>
          </div>
          <div class="col-lg-6">
            <div class="mail_box">
              <div class="input-group">
              <form method="POST" action="mail.php" enctype="multipart/form-data">            
                <input type="text" class="form-control" id="txtEmail" name="txtEmail" placeholder="&#xe997; Nhập email của bạn" 
                    aria-label="Recipient's username" aria-describedby="button-addon2"/>           
                <div class="input-group-append">
                  <button class="btn btn-outline-secondary" type="submit" >
                  <i class="fas fa-long-arrow-alt-right"></i>
                  </button>
                </div>               
              </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
    <!--================End Subscribe Area =================-->

    <!--================Footer Area =================-->
    <footer class="footer_area">
      <div class="footer_widgets_area pad_top">
        <div class="container">
          <div class="row">

            <div class="col-lg-4">
              <aside class="f_widget contact_widget">
                <div class="f_title">
                  <h3>LIÊN HỆ</h3>
                </div>

                <div class="ct_wd_text">
                  <div class="media">
                    <div class="media-body">                 
                        <p>
                          <i class="fas fa-phone-alt"></i>
                          Hotline: 024 3825 5599
                        </p>                   
                    </div>
                  </div>
                  
                  <div class="media">
                    <div class="media-body">
                      <p>
                      <i class="fas fa-envelope"></i>
                        Email: pccovid19s@gmail.com
                      </p>
                    </div>
                  </div>

                  <div class="media">
                    <div class="media-body">
                      <p>
                        <i class="fas fa-home"></i>
                        Địa chỉ: 36 Ngô Quyền, phường Hàng Bài,
                        </br> quận Hoàn Kiếm, Hà Nội
                      </p>
                    </div>
                  </div>                     
                </div>
              </aside>
            </div>

            <div class="col-lg-4">
              <aside class="f_widget contact_widget">
                <div class="f_title">
                  <h3>THỐNG KÊ</h3>
                </div>
              <div class="ct_wd_text">
                <div class="media">
                  <div class="media-body">
                    <p>
                      <i class="far fa-eye"></i>
                      Số lượt đang truy cập
                    </p>
                  </div>
                </div>
                <div class="media">
                  <div class="media-body">
                    <p>
                      <i class="fas fa-globe-americas"></i>
                      Tổng số lượt truy cập:
                      <?php
                        include('config.php');
                        $sql1= "SELECT * FROM tbl_truy_cap ";
                        $truy_cap= mysqli_fetch_array(mysqli_query($ket_noi,$sql1));
                        $_SESSION['truycap']= $truy_cap['luot_truy_cap'];
                        if(isset($_SESSION['truycap']))
                        $_SESSION['truycap']+=1;
                        $sql2 = "UPDATE `tbl_truy_cap` SET luot_truy_cap = '".$_SESSION['truycap']."' WHERE `tbl_truy_cap`.`truy_cap_id` = 1";  
                        $lan_xem = mysqli_query($ket_noi, $sql2);
                        echo $truy_cap['luot_truy_cap']+1;
                      ;?>
                    </p>
                  </div>
                </div>
              </div>   
              </aside>
            </div>

            <div class="col-lg-4">
             <div class="gg-fb">
                <div>
                  <div class="fb-page page-fb" data-href="https://www.facebook.com/trungtamytequanhoankiem36ngoquyen" data-tabs="timeline" data-width="270" data-height="152" data-small-header="false" data-adapt-container-width="false" data-hide-cover="false" data-show-facepile="false"><blockquote cite="https://www.facebook.com/trungtamytequanhoankiem36ngoquyen" class="fb-xfbml-parse-ignore"><a href="https://www.facebook.com/trungtamytequanhoankiem36ngoquyen">Trung Tâm Y Tế Quận Hoàn Kiếm:36 Ngô Quyền</a></blockquote></div>
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3724.2281567295654!2d105.85251131402812!3d21.023554993333946!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3135abec902b9623%3A0xdfe9443e9ca77d59!2zVHJ1bmcgVMOibSBZIFThur8gUXXhuq1uIEhvw6BuIEtp4bq_bSAzNg!5e0!3m2!1svi!2s!4v1634628981628!5m2!1svi!2s" width="270" height="150" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
                  </div>
                </div>
              </div>
            </div>

          </div>
        </div>
        <div class="footer_copyright">
          <img src="images/logoo.png" alt="">
          <p>
            © Copyright
            <script>
              document.write(new Date().getFullYear());
            </script>
            HALN PC-Covid.
          </p>
          <ul class="nav">
            <li><a href="#">Điều khoản sử dụng</a></li>
            <li><a href="#">Chính sách bảo mật</a></li>
            <li><a href="#">Dấu ấn</a></li>
          </ul>
          <h6>
              by <span>nhóm HALN</span>
          </h6>
        </div>
      </div>
    </footer>
    <!--================End Footer Area =================-->
  </div>
  <div class="modal fade search_modal" id="exampleModal" tabindex="-1" role="dialog" aria-hidden="true">
    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
      <img src="images/icon/close-white.png" alt="">
    </button>
    <div class="modal-dialog" role="document">
      <div class="modal-content">
        <div class="modal-body">
          <div class="input-group">
            <input type="text" class="form-control" placeholder="Nội dung tìm kiếm..." aria-label="Recipient's username">
            <div class="input-group-append">
              <button class="btn btn-outline-secondary" type="button"><i class="linearicons-magnifier"></i></button>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>

  <!-- Optional JavaScript -->
  <!-- jQuery first, then Popper.js, then Bootstrap JS -->
  <script src="js/jquery-3.4.1.min.js"></script>
  <script src="js/popper.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="vendors/corona-live/dashboard.js"></script>
  <script src="vendors/isotop/imagesloaded.pkgd.min.js"></script>
  <script src="vendors/isotop/isotope.pkgd.min.js"></script>
  <script src="vendors/slick/slick.min.js"></script>
  <script src="vendors/scroll-animation/jquery.parallax-scroll.js"></script>
  <script src="vendors/scroll-animation/parallax.js"></script>
  <script src="vendors/mCustomScrollbar/jquery.mCustomScrollbar.concat.min.js"></script>
  <script src="vendors/animate-css/wow.min.js"></script>
  <script src="js/jquery.validate.min.js"></script>
  <script src="js/theme.js"></script>
  <script async defer crossorigin="anonymous" src="https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v12.0" nonce="XVpXxaji"></script>
  </body>

</html>