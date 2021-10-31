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
  <link rel="stylesheet" href="vendors/fontawesome/css/all.min.css" />
  <link rel="stylesheet" href="vendors/linearicons/css/linearicons.css" />
  <link rel="stylesheet" href="vendors/slick/slick.css" />
  <link rel="stylesheet" href="vendors/slick/slick-theme.css" />
  <link rel="stylesheet" href="vendors/datetimepicker/tempusdominus-bootstrap-4.min.css" />
  <link rel="stylesheet" href="vendors/mCustomScrollbar/jquery.mCustomScrollbar.min.css" />
  <link rel="stylesheet" href="vendors/animate-css/animate.css" />

  <!-- main css -->
  <link rel="stylesheet" href="css/style.css" />
  <link rel="stylesheet" href="css/responsive.css" />
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
            <a href="index.html">Phòng chống
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
          <li class="active">
          <a href="#">Giới thiệu
              <i class="linearicons-chevron-down"></i>
            </a>
            <ul class="list">          
              <li><a href="coronavirus.php">Về COVID-19</a></li>
              <li><a href="doctors.php">Đội ngũ bác sĩ</a></li>
              <li><a href="vaccine.php">Tin tức</a></li>
            </ul>
          </li>
          <li>
            <a href="blog.php">Tin tức</a>
            </a>
          </li>
          <a href="contact.php">Liên hệ</a>
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
                <li class="active" ><a href="appointment.php">Tư vấn</a></li>
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
                <li class="">
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
<section class="breadcrumb_area boi_breadcrumb">
      <div class="container">
        <div class="breadcrumb_text">
          <h6 class="wow fadeInUp">Tham khảo ý kiến của các chuyên gia</h6>
          <h3 class="wow fadeInUp" data-wow-delay="0.2s">Tư vấn online</h3>
          <ul class="nav justify-content-center wow fadeInUp" data-wow-delay="0.3s">
            <li><a href="index.php">Trang chủ</a></li>
            <li><a href="doctors.php">Tư vấn</a></li>
          </ul>
        </div>
        <div class="row appointment_box">
          <div class="col-lg-4 appoinment_features">
            <div class="shape one" data-parallax='{"y": 100}'>
              <img src="images/appoinment/a_img1.png" alt="" />
            </div>
            <div class="shape two">
              <img src="images/appoinment/a_img2.png" alt="" />
            </div>
            <div class="shape three">
              <img src="images/appoinment/a_img3.png" alt="" />
            </div>
            <div class="shape four" data-parallax='{"x": 30}'>
              <img src="images/appoinment/a_img4.png" alt="" />
            </div>
            <div class="shape five">
              <img src="images/appoinment/a_img5.png" alt="" />
            </div>
            <div class="shape six" data-parallax='{"y": 50}'>
              <img src="images/appoinment/a_img6.png" alt="" />
            </div>
            <h2>Đặt lịch hẹn</h2>
            <p>
              Vui lòng để lại thông tin của bạn và chúng tôi sẽ liên hệ lại sớm.
            </p>
            <div class="media appoinment_features_item">
              <i class="linearicons-medal-empty"></i>
              <div class="media-body">
                <h6>Đội ngũ bác sĩ nổi tiếng</h6>
                <p>với nhiều kinh nghiệm</p>
              </div>
            </div>
            <div class="media appoinment_features_item">
              <i class="linearicons-clipboard-check"></i>
              <div class="media-body">
                <h6>Lời khuyên hữu ích</h6>
                <p>Chúng tôi sẽ cung cấp cho bạn những thông tin cần thiết</p>
              </div>
            </div>
            <div class="media appoinment_features_item">
              <i class="linearicons-tags"></i>
              <div class="media-body">
                <h6>Hoàn toàn miễn phí</h6>
                <p>Không cần lo lắng về chi phí</p>
              </div>
            </div>
          </div>
          <div class="col-lg-8">
            <form method="POST" action="add_appointment.php" class="appoinment_form">
              <div class="row">

                <div class="col-lg-6">
                  <div class="form-group">
                    <input class="form-control" type="text" id="txtHoTen" name="txtHoTen" placeholder="" required/>
                    <label><i class=""></i>Họ tên</label>
                  </div>
                </div>
                
                <div class="col-lg-6">
                  <div class="form-group">
                    <input class="form-control" type="text" id="txtEmail" name="txtEmail" placeholder="" required/>
                    <label><i class=""></i>Email</label>
                  </div>
                </div>                                    

                <div class="col-lg-6">
                  <div class="form-group input-group date" id="datetimepicker3" data-target-input="nearest">
                    <div class="input-group-append" data-target="#datetimepicker3" data-toggle="datetimepicker">
                      <div class="input-group-text">
                        <i class="linearicons-calendar-text"></i>
                      </div>
                    </div>
                    <div class="text_div">
                      Ngày tư vấn
                    </div>
                    <input type="text" name="datetimepicker3" class="form-control datetimepicker-input" data-target="#datetimepicker3"
                      data-toggle="datetimepicker" required/>
                  </div>      
                  
                  <h5>Giới tính</h5>
                    <div>
                      <select class="form-control" name="txtGioiTinh" id="txtGioiTinh" required>
                        <option value="Nam">Nam</option>
                        <option value="Nữ">Nữ</option>
                        <option value="Khác">Khác</option>
                      </select> 
                    </div>                
                </div>

                <div class="col-lg-6">
                  <div class="form-group input-group date" id="datetimepicker4" data-target-input="nearest">
                    <div class="input-group-append" data-target="#datetimepicker4" data-toggle="datetimepicker">
                      <div class="input-group-text">
                        <i class="linearicons-alarm2"></i>
                      </div>
                    </div>
                    <div class="text_div">
                      Thời gian 
                    </div>
                    <input type="text" name="datetimepicker4" class="form-control datetimepicker-input" data-target="#datetimepicker4"
                      data-toggle="datetimepicker" required/>
                  </div>
                
                  <div class="form-group select_conversation_inner" >
                    <h5>Chọn phương thức trao đổi</h5>
                      <div>
                        <select class="form-control" name="txtPhuongThuc" id="txtPhuongThuc" required>
                          <option value="Gọi điện thoại">Gọi điện thoại</option>
                          <option value="Qua Video">Qua Video</option>
                          <option value="Nhắn tin trao đổi">Nhắn tin trao đổi</option>
                        </select> 
                    </div>
                  </div>             
                </div>             
                  
                <div class="col-lg-6">
                  <div class="form-group">
                    <input class="form-control" type="text" id="txtPhone" name="txtPhone" placeholder="" required/>
                    <label><i class=""></i>Số điện thoại</label>
                  </div>
                </div>   

                <div class="col-lg-6">
                  <div class="form-group">                      
                    <input class="form-control" type="text" id="txtGhiChu" name="txtGhiChu" placeholder="" required/>
                    <label><i class=""></i>Ghi chú</label>
                  </div>
                </div>
                  
                  <div class="col-lg-12">
                    <div class="form-group checkbox_field">                  
                      <button type="submit" class="green_btn" value="appoinment" data-value="appoinment">
                        Gửi
                      </button>
                    </div>
                  </div>

              </div>
            </form>
          </div>
        </div>
      </div>
    </section>
    <!--================End Breadcrumb Area =================-->

    <!--================Starrt Work Area =================-->
    <section class="work_area">
      <div class="container">
        <div class="row align-items-center">
          <div class="col-lg-6">
            <div class="work_content">
              <div class="main_title">
                
                <h2>Cách thức hoạt động </h2>
                <h5>Vô cùng đơn giản</h5>
              </div>
              <ol class="work_list">
                <li class="wow fadeInUp" data-wow-delay="0.1s">Nhập thông tin liên hệ để chúng tôi có thể kết nối với bạn qua Gmail
                </li>
                <li class="wow fadeInUp" data-wow-delay="0.2s">Lựa chọn ngày, giờ mong muốn </li>
                <li class="wow fadeInUp" data-wow-delay="0.3s">Lựa chọn phương thức trao đổi</li>
                <li class="wow fadeInUp" data-wow-delay="0.4s">Mô tả những vấn đề bạn đang gặp phải</li>
                
              </ol>
            </div>
          </div>
          <div class="col-lg-6 text-center">
            <img data-wow-delay="400ms" class="img-fluid wow fadeInRight" src="images/appoinment/works.jpg"
              alt="">
          </div>
        </div>
      </div>
    </section>
    <!--================End work Area =================-->
    <!--================Client Logo Area =================-->
    <section class="client_logo_area pad_top">
      <div class="container">
        <div class="client_slider">
          <div class="item">
            <img src="images/client-logo/client-logo-1.png" alt="" />
          </div>
          <div class="item">
            <img src="images/client-logo/client-logo-2.png" alt="" />
          </div>
          <div class="item">
            <img src="images/client-logo/client-logo-3.png" alt="" />
          </div>
          <div class="item">
            <img src="images/client-logo/client-logo-4.png" alt="" />
          </div>
          <div class="item">
            <img src="images/client-logo/client-logo-5.png" alt="" />
          </div>
          <div class="item">
            <img src="images/client-logo/client-logo-6.png" alt="" />
          </div>
          <div class="item">
            <img src="images/client-logo/client-logo-1.png" alt="" />
          </div>
          <div class="item">
            <img src="images/client-logo/client-logo-2.png" alt="" />
          </div>
          <div class="item">
            <img src="images/client-logo/client-logo-3.png" alt="" />
          </div>
          <div class="item">
            <img src="images/client-logo/client-logo-4.png" alt="" />
          </div>
          <div class="item">
            <img src="images/client-logo/client-logo-5.png" alt="" />
          </div>
          <div class="item">
            <img src="images/client-logo/client-logo-6.png" alt="" />
          </div>
        </div>
      </div>
    </section>
    <!--================End Client Logo Area =================-->
        <!--================Check Now Area =================-->
        <section class="check_now_area check_now_box full_widget_check">
            <div class="container">
                <div class="row m-0 justify-content-between">
                    <div class="left">
                        <div class="media">
                            <div class="d-flex">
                                <img src="images/check-4.png" alt="">
                                <img src="images/check-5.png" alt="">
                                <img src="images/check-6.png" alt="">
                            </div>
                            <div class="media-body">
                                <h4>Bạn nghi ngờ mình bị lây nhiễm?</h4>
                                <p>
                                   Chủ động xét nghiệm Covid-19
                                   <br>Bảo vệ chính mình, người thân và cộng đồng.
                                </p>                              
                            </div>
                        </div>
                    </div>
                    <div class="right">
                        <a class="icon_btn wow fadeInRight" href="symptom-checker.php">Đăng ký test Covid ngay<i class="far fa-arrow-right"></i></a>
                    </div>
                </div>
            </div>
        </section>
        <!--================End Check Now Area =================-->

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
  <script src="vendors/datetimepicker/moment.js"></script>
  <script src="vendors/datetimepicker/tempusdominus-bootstrap-4.min.js"></script>
  <script src="vendors/mCustomScrollbar/jquery.mCustomScrollbar.concat.min.js"></script>
  <script src="vendors/animate-css/wow.min.js"></script>
  <script src="vendors/scroll-animation/jquery.parallax-scroll.js"></script>
  <script src="js/jquery.validate.min.js"></script>
  <script src="js/theme.js"></script>
  <script async defer crossorigin="anonymous" src="https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v12.0" nonce="XVpXxaji"></script>
  </body>

</html>