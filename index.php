<!DOCTYPE html>
<html lang="en">

<head>
  <!-- Required meta tags -->
  <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
  <link rel="icon" href="images/favicon.png" type="image/png" />
  <title>COVID - 19</title>
  <!-- Bootstrap CSS -->
  <link rel="stylesheet" href="https://cdn.linearicons.com/free/1.0.0/icon-font.min.css">
  <link rel="stylesheet" href="css/bootstrap.min.css" />
  <link rel="stylesheet" href="vendors/fontawesome/css/all.css" />
  <link rel="stylesheet" href="vendors/linearicons/css/linearicons.css" />
  <link rel="stylesheet" href="vendors/slick/slick.css" />
  <link rel="stylesheet" href="vendors/slick/slick-theme.css" />
  <link rel="stylesheet" href="vendors/mCustomScrollbar/jquery.mCustomScrollbar.min.css" />
  <link rel="stylesheet" href="vendors/animate-css/animate.css" />

  <!-- main css -->
  <link rel="stylesheet" href="css/style.css" />
  <link rel="stylesheet" href="css/responsive.css" />
</head>

<body data-scroll-animation="true">
  <?php
    
  ?>
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
                <li class="active"><a href="index.php ">Trang chủ</a></li>
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

    <!--================Home Banner Area =================-->
    <section class="home_banner_area">
      <div class="container">
        <div class="row home_banner_inner">
          <div class="col-sm-7">
            <h5 class="wow fadeInUp" data-wow-delay="300ms">Stop COVID-19</h5>
            <h3 class="wow fadeInUp" data-wow-delay="500ms">CHUNG TAY ĐẨY LÙI DỊCH BỆNH COVID-19
            </h3>
            <p class="wow fadeInUp" data-wow-delay="400ms">
              Chúng ta đều là công dân toàn cầu, và chúng ta đều có một phần trách nhiệm cho cuộc chiến này. Chủng coronavirus mới đã đạt tới mức đại dịch.
            </p>
            <a class="main_btn wow fadeInLeft" data-wow-delay="300ms" href="prevention.php">Phòng chống dịch</a>
            <div class="row home_option">
              <div class="col-lg-6 wow fadeIn" data-wow-delay="300ms">
                <div class="media">
                  <div class="d-flex">
                    <i class="fas fa-shield-virus"></i>
                  </div>
                  <div class="media-body">
                    <h4>Sự bảo vệ</h4>
                    <p>Làm thế nào để bảo vệ bản thân</p>
                  </div>
                </div>
              </div>
              <div class="col-lg-6 wow fadeIn" data-wow-delay="400ms">
                <div class="media">
                  <div class="d-flex">
                    <i class="fas fa-user-check"></i>
                  </div>
                  <div class="media-body">
                    <h4>Triệu chứng</h4>
                    <p>Kiểm tra các triệu chứng cơ bản</p>
                  </div>
                </div>
              </div>
              <div class="col-lg-6 wow fadeIn" data-wow-delay="500ms">
                <div class="media">
                  <div class="d-flex">
                    <i class="fas fa-comments"></i>                  
                  </div>
                  <div class="media-body">
                    <h4>Tư vấn</h4>
                    <p>Nhận tư vấn trực tuyến</p>
                  </div>
                </div>
              </div>
              <div class="col-lg-6 wow fadeIn" data-wow-delay="600ms">
                <div class="media">
                  <div class="d-flex">
                    <i class="fas fa-file-medical-alt"></i>
                  </div>
                  <div class="media-body">
                    <h4> COVID-19</h4>
                    <p>Đọc thêm về coronavirus</p>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-sm-5">
            <img class="img-fluid wow fadeInRight" data-wow-delay="400ms"
              src="images/svg/home-banner-cleaner.svg" alt="" />
          </div>
        </div>
      </div>
    </section>
    <!--================End Home Banner Area =================-->

    <!--================Check Now Area =================-->
    <section class="check_now_area">
      <div class="container">
        <div class="row m-0 justify-content-between">
          <div class="left">
            <div class="media">
              <div class="d-flex">
                <img src="images/check-1.png" alt="" />
                <img src="images/check-2.png" alt="" />
                <img src="images/check-3.png" alt="" />
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
            <a class="icon_btn wow fadeInRight" data-wow-delay="400ms" href="symptom-checker.php">Đăng ký test Covid ngay<i class="far fa-arrow-right"></i></a>
          </div>
        </div>
      </div>
    </section>
    <!--================End Check Now Area =================-->

    <!--================Home About Area =================-->
    <section class="home_about_corona">
      <div class="container">
        <div class="row">
          <div class="col-lg-6">
            <div class="home_ab_img wow fadeInUp" data-wow-delay="400ms">
              <img src="images/about1.png" alt="" />
            </div>
          </div>
          <div class="col-lg-6">
            <div class="home_ab_text">
              <div class="home_ab_text_inner">
                <div class="home_ab_item">
                  <h6>DỊCH COVID-19 </h6>
                  <h4>Giới thiệu về Coronavirus</h4>
                  <p>
                   Bệnh Coronavirus 2019 (COVID-19) là một bệnh truyền nhiễm do virus 
                   Corona gây hội chứng hô hấp cấp tính nghiêm trọng 2. 
                   Căn bệnh này được xác định lần đầu tiên vào năm 2019 tại Vũ Hán,
                    thủ phủ của Hồ Bắc, Trung Quốc và từ đó lan rộng ra toàn cầu, 
                    dẫn đến năm 2019–2020 đại dịch do vi-rút corona gây ra.
                  </p>
                </div>
                <div class="home_ab_item">
                  <h4>COVID-19 là gì?</h4>
                  <p>
                    COVID-19 là một dòng coronavirus mới chưa được xác định trước đây ở người. 
                    Nó được xác định lần đầu tiên ở Vũ Hán, tỉnh Hồ Bắc, Trung Quốc, 
                    nơi nó đã gây ra một đợt bùng phát lớn và đang diễn ra. Nó đã lan rộng hơn ở Trung Quốc.
                  </p>
                  <a class="text_btn" href="coronavirus.php">Đọc thêm về <i class="fas fa-arrow-right"></i></a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!--================Symptoms Area =================-->
    <section class="symptoms_area">
      <div class="container">
        <ul class="nav image_list">
          <li><img src="images/symptoms-user/sm-1.png" alt=""></li>
          <li><img src="images/symptoms-user/sm-2.png" alt=""></li>
          <li><img src="images/symptoms-user/sm-3.png" alt=""></li>
        </ul>
        <div class="title_text wow fadeInUp" data-wow-delay="400ms">
          <h5>Các triệu chứng của COVID-19</h5>
          <h2>Các triệu chứng cơ bản của COVID-19</h2>
        </div>
        <div class="row symptoms_inner">
          <div class="col-lg-6 wow fadeInUp" data-wow-delay="400ms">
            <div class="symptoms_item">
              <div class="media">
                <div class="d-flex">
                  <img src="images/symptoms-user/symptoms-1.png" alt="" />
                </div>
                <div class="media-body">
                  <h4>Sốt cao</h4>
                  <p>
                    Sau thời gian ủ bệnh (từ 2 đến 14 ngày). Sốt được xác định có nguy cơ mắc COVID-19 là đạt ít nhất 39 ° C thường kèm theo giảm chức năng vị giác và khứu giác.
                  </p>
                </div>
              </div>
            </div>
          </div>
          <div class="col-lg-6 wow fadeInUp" data-wow-delay="500ms">
            <div class="symptoms_item">
              <div class="media">
                <div class="d-flex">
                  <img src="images/symptoms-user/symptoms-2.png" alt="" />
                </div>
                <div class="media-body">
                  <h4>Khó thở</h4>
                  <p>
                    Bạn cảm thấy nóng khi chạm vào ngực hoặc lưng Đây là một dấu hiệu phổ biến và cũng có thể xuất hiện sau 2-10 ngày nếu bạn bị ảnh hưởng.
                  </p>
                </div>
              </div>
            </div>
          </div>
          <div class="col-lg-6 wow fadeInUp" data-wow-delay="600ms">
            <div class="symptoms_item">
              <div class="media">
                <div class="d-flex">
                  <img src="images/symptoms-user/symptoms-3.png" alt="" />
                </div>
                <div class="media-body">
                  <h4>Ho khan</h4>
                  <p>
                    Ho là một triệu chứng quan trọng khác, nhưng nó không chỉ là bất kỳ cơn ho nào. Đó hẳn là một cơn ho khan mà bạn cảm thấy tức ngực
                  </p>
                </div>
              </div>
            </div>
          </div>
          <div class="col-lg-6 wow fadeInUp" data-wow-delay="700ms">
            <div class="symptoms_item">
              <div class="media">
                <div class="d-flex">
                  <img src="images/symptoms-user/symptoms-4.png" alt="" />
                </div>
                <div class="media-body">
                  <h4>Đau đầu</h4>
                  <p>
                    Cứ 6 người thì có 1 người nhiễm COVID-19 bị bệnh nặng và khó thở hoặc thở gấp.
                  </p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
    <!--================End Symptoms Area =================-->

    <!--================Protect Yourself Area =================-->
    <section class="protect_yourself_area p_100">
      <div class="container">
        <div class="main_title text-center">
          <h5>Bạn cần làm gì</h5>
          <h2>để tự bảo vệ bản thân</h2>
        </div>
        <div class="row protect_inner">
          <div class="col-lg-6">
            <div class="row protect_list_inner">
              <div class="col-6">
                <div class="protect_list_item">
                  <div class="protect_list_title">
                    <h3>Bạn nên làm</h3>
                    <h6>Hãy làm theo</h6>
                  </div>
                  <ul class="nav flex-column">
                    <li>
                      <a href="#"><i class="fas fa-home"></i></i>Ở nhà là chống dịch</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-head-side-mask"></i>Đeo khẩu trang</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-box-tissue"></i>Luôn sử dụng khăn giấy</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-couch"></i>Khử trùng nhà của bạn</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-hands-wash"></i>Luôn rửa tay</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-thermometer"></i>Tự cách ly</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-prescription-bottle-alt"></i>Ăn uống lành mạnh.</a>
                    </li>
                    
                  </ul>
                </div>
              </div>
              <div class="col-6">
                <div class="protect_list_item red">
                  <div class="protect_list_title">
                    <h3>Bạn nên tránh</h3>
                    <h6>Hãy làm theo</h6>
                  </div>
                  <ul class="nav flex-column">
                    <li>
                      <a href="#"><i class="fas fa-people-arrows"></i>Không tụ tập đông người</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-paw"></i>Tránh động vật</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-fist-raised"></i>Không đưa tay lên mặt</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-handshake-slash"></i>Không bắt tay</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-chair"></i>Tránh tiếp xúc các bề mặt</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-tint-slash"></i>Tránh các giọt bắn</a>
                    </li>
                    <li>
                      <a href="#"><i class="fas fa-plane-slash"></i>Không đi du lịch</a>
                    </li>
                  </ul>
                </div>
              </div>
            </div>
            <div class="protect_self_text">
              <h3>Tự cách ly tại nhà như thế nào?</h3>
              <p>
                Nếu bạn cần phải tự cách li, bạn nên hành động ngay lập tức. Bạn phải ở trong nhà và tránh tiếp xúc với người khác.
              </p>
              <a class="text_btn" href="prevention.php">Bạn có thể tự bảo vệ mình bằng cách nào khác?
                <i class="fas fa-arrow-right"></i></a>
            </div>
          </div>
          <div class="col-lg-6">
            <div class="protect_img text-center apps_craft_animation">
              <img class="img-fluid wow fadeIn" data-wow-delay="500ms" src="images/protect01.jpg" alt="" />
              <ul class="nav">
                <li><img src="images/icon/project-virus-1.png" alt=""></li>
                <li><img src="images/icon/project-virus-2.png" alt=""></li>
                <li><img class="layer layer2" data-depth="0.5" src="images/icon/project-virus-3.png" alt=""></li>
                <li><img src="images/icon/project-virus-4.png" alt=""></li>
                <li><img src="images/icon/project-virus-5.png" alt=""></li>
                <li><img src="images/icon/project-virus-6.png" alt=""></li>
                <li><img src="images/icon/project-virus-7.png" alt=""></li>
                <li><img src="images/icon/project-virus-8.png" alt=""></li>
                <li><img class="layer layer2" data-depth="0.5" src="images/icon/project-virus-9.png" alt=""></li>
                <li><img src="images/icon/project-virus-10.png" alt=""></li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </section>
    <!--================End Protect Yourself Area =================-->

    <!--================Washing Process Area =================-->
    <section class="washing_process_area pad_btm">
      <div class="container">
        <div class="main_title text-center white">
          <h5>Quy trình rửa tay</h5>
          <h2>Rửa tay đúng cách</h2>
        </div>
        <div class="washing_process_inner row">
          <div class="col-lg-2 col-sm-4 col-6 wow fadeIn" data-wow-delay="400ms">
            <div class="washing_item">
              <div class="icon">
                <img src="images/icon/washing-1.png" alt="" />
                <div class="number">
                  1
                </div>
              </div>
              <p><span>Thoa xà phòng</span> và xoa hai tay lại với nhau</p>
            </div>
          </div>
          <div class="col-lg-2 col-sm-4 col-6 wow fadeIn" data-wow-delay="500ms">
            <div class="washing_item">
              <div class="icon">
                <img src="images/icon/washing-2.png" alt="" />
                <div class="number">
                  2
                </div>
              </div>
              <p>
                <span>Dùng một tay</span> xoa mu bàn tay kia và ngược lại.</p>
            </div>
          </div>
          <div class="col-lg-2 col-sm-4 col-6 wow fadeIn" data-wow-delay="600ms">
            <div class="washing_item">
              <div class="icon">
                <img src="images/icon/washing-3.png" alt="" />
                <div class="number">
                  3
                </div>
              </div>
              <p>
                <span>Xoa hai bàn tay </span> với nhau và làm sạch giữa các ngón tay của bạn
              </p>
            </div>
          </div>
          <div class="col-lg-2 col-sm-4 col-6 wow fadeIn" data-wow-delay="700ms">
            <div class="washing_item">
              <div class="icon">
                <img src="images/icon/washing-4.png" alt="" />
                <div class="number">
                  4
                </div>
              </div>
              <p>
                <span>Xoa mu bàn tay</span> vào lòng bàn tay
              </p>
            </div>
          </div>
          <div class="col-lg-2 col-sm-4 col-6 wow fadeIn" data-wow-delay="800ms">
            <div class="washing_item">
              <div class="icon">
                <img src="images/icon/washing-5.png" alt="" />
                <div class="number">
                  5
                </div>
              </div>
              <p>
                <span>Dùng tay kia</span> xoa ngón tay cái và ngược lại
              </p>
            </div>
          </div>
          <div class="col-lg-2 col-sm-4 col-6 wow fadeIn" data-wow-delay="900ms">
            <div class="washing_item">
              <div class="icon">
                <img src="images/icon/washing-6.png" alt="" />
                <div class="number">
                  6
                </div>
              </div>
              <p>
                <span>Xoa các đầu ngón tay</span> vào lòng bàn tay kia và ngược lại
              </p>
            </div>
          </div>
        </div>
      </div>
    </section>
    <!--================End Washing Process Area =================-->

    <!--================Prevent Area =================-->
    <section class="prevent_area">
      <div class="container">
        <div class="row prevent_inner">
          <div class="col-lg-6">
            <div class="prevent_item_inner row">
              <div class="col-sm-6 wow fadeInUp" data-wow-delay="400ms">
                <div class="prevent_item">
                  <div class="prevent_img">
                    <img class="img-fluid" src="images/prevent/prevent-1.png" alt="" />
                  </div>
                  <div class="prevent_text">
                    <h4>Hãy ở nhà</h4>
                    <p>
                      Hãy ở nhà nếu bạn nhận thấy các triệu chứng và hỏi ý kiến ​​bác sĩ qua điện thoại.
                    </p>
                  </div>
                </div>
              </div>
              <div class="col-sm-6 wow fadeInUp" data-wow-delay="500ms">
                <div class="prevent_item">
                  <div class="prevent_img">
                    <img class="img-fluid" src="images/prevent/prevent-2.png" alt="" />
                  </div>
                  <div class="prevent_text">
                    <h4>Rửa tay thường xuyên</h4>
                    <p>
                      Làm sạch tay bằng chất tẩy rửa có cồn hoặc rửa bằng xà phòng trong ít nhất 20 giây
                    </p>
                  </div>
                </div>
              </div>
              <div class="col-sm-6 wow fadeInUp" data-wow-delay="600ms">
                <div class="prevent_item">
                  <div class="prevent_img">
                    <img class="img-fluid" src="images/prevent/prevent-3.png" alt="" />
                  </div>
                  <div class="prevent_text">
                    <h4>Giãn cách xã hội</h4>
                    <p>
                      Giữ khoảng cách ít nhất 2 m giữa bạn và bất kỳ ai nếu bạn<br> đi giữa mọi người.
                    </p>
                  </div>
                </div>
              </div>
              <div class="col-sm-6 wow fadeInUp" data-wow-delay="700ms">
                <div class="prevent_item">
                  <div class="prevent_img">
                    <img class="img-fluid" src="images/prevent/prevent-4.png" alt="" />
                  </div>
                  <div class="prevent_text">
                    <h4>Đeo khẩu trang</h4>
                    <p>
                      Khi bạn ở gần những người khác và trước khi bạn vào nhà cung cấp dịch vụ chăm sóc sức khỏe.
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-lg-6">
            <div class="prevent_details">
              <div class="prevent_details_text">
                <h5>Bạn nên làm gì những gì?</h5>
                <h2>Làm thế nào để ngăn chặn Virus Corona?</h2>
                <p>
                  Một số điểm về cách thức lây lan của căn bệnh này đã được xác định. WHO và CDC tuyên bố rằng căn bệnh này chủ yếu lây lan khi tiếp xúc gần và do các giọt bắn tạo ra khi người ta ho hoặc hắt hơi; tiếp xúc gần trong vòng 1 đến 2 mét. Một nghiên cứu ở Singapore đã phát hiện ra rằng một cơn ho khi không đeo khẩu trang có thể dẫn đến những giọt nhỏ bay đến 4,5 mét.
                </p>
                <p>
                  Các giọt bắn qua hô hấp cũng có thể được tạo ra trong quá trình thở ra, kể cả khi nói chuyện, mặc dù vi-rút nói chung không lây nhiễm trong không khí. Những giọt này có thể rơi vào miệng hoặc mũi của những người ở gần đó hoặc có thể bị hít vào phổi...
                </p>
                <a class="green_btn" href="prevention.php"><i class="linearicons-shield-check"></i>Đọc thêm về Phòng chống COVID-19</a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
    <!--================End Prevent Area =================-->

    <!--================Answers Area =================-->
    
    <!--================End Home About Area =================-->
    <section class="faq_area">
      <div class="container">
        <div class="main_title">
          <h5>Có một vài câu hỏi? Tìm câu trả lời!</h5>
          <h2>Các câu hỏi thường gặp</h2>
        </div>
        <div class="row answer_inner">
          <div class="col-lg-4">
            <div class="question_list">
              <div class="accordion" id="accordionExample">
                <div class="card">
                  <div class="card-header" id="headingOne">
                    <button class="btn btn-link" type="button" data-toggle="collapse" data-target="#collapseOne"
                      aria-expanded="true" aria-controls="collapseOne">
                      Đại dịch
                      <i class="fas fa-chevron-down"></i>
                    </button>
                  </div>

                  <div id="collapseOne" class="collapse show" aria-labelledby="headingOne"
                    data-parent="#accordionExample">
                    <div class="card-body">
                      <ul class="nav nav-tabs" id="myTab" role="tablist">
                        <li class="nav-item">
                          <a class="nav-link active" id="home-tab" data-toggle="tab" href="#home" role="tab"
                            aria-controls="home" aria-selected="true">Coronavirus là gì?</a>
                        </li>
                        <li class="nav-item">
                          <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab"
                            aria-controls="profile" aria-selected="false">Sự khác biệt giữa COVID-19 và bệnh cúm là gì?</a>
                        </li>
                        <li class="nav-item">
                          <a class="nav-link" id="contact-tab" data-toggle="tab" href="#contact" role="tab"
                            aria-controls="contact" aria-selected="false">Virus lây lan như thế nào?</a>
                        </li>
                        <li class="nav-item">
                          <a class="nav-link" id="four-tab" data-toggle="tab" href="#four" role="tab"
                            aria-controls="four" aria-selected="false">Các triệu chứng như thế nào?</a>
                        </li>
                      </ul>
                    </div>
                  </div>
                </div>
                <div class="card">
                  <div class="card-header" id="headingThree">
                    <button class="btn btn-link collapsed" type="button" data-toggle="collapse"
                      data-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                     Triệu chứng Coronavirus
                      <i class="fas fa-chevron-down"></i>
                    </button>
                  </div>
                  <div id="collapseThree" class="collapse" aria-labelledby="headingThree"
                    data-parent="#accordionExample">
                    <div class="card-body">
                      <ul class="nav nav-tabs" id="myTab3" role="tablist">
                        <li class="nav-item">
                          <a class="nav-link" id="home3-tab" data-toggle="tab" href="#home3" role="tab"
                            aria-controls="home3" aria-selected="true">Sự khác biệt giữa COVID-19 & bệnh cúm?</a>
                        </li>
                        <li class="nav-item">
                          <a class="nav-link" id="profile3-tab" data-toggle="tab" href="#profile3" role="tab"
                            aria-controls="profile3" aria-selected="false">Triệu chứng gây ra bởi virus SARS-CoV-2 qua từng ngày?</a>
                        </li>
                        <li class="nav-item">
                          <a class="nav-link" id="contact3-tab" data-toggle="tab" href="#contact3" role="tab"
                            aria-controls="contact3" aria-selected="false">Biểu hiện của bệnh COVID-19 có sổ mũi không?</a>
                        </li>
                        <li class="nav-item">
                          <a class="nav-link" id="four3-tab" data-toggle="tab" href="#four3" role="tab"
                            aria-controls="four3" aria-selected="false">Biểu hiện sớm nhất của bệnh COVID-19 gây ra bởi virus SARS-CoV-2 là gì?</a>
                        </li>
                        <li class="nav-item">
                          <a class="nav-link" id="five3-tab" data-toggle="tab" href="#five3" role="tab"
                            aria-controls="five3" aria-selected="false">Triệu chứng của COVID-19 có nghẹt mũi không?</a>
                        </li>
                      </ul>
                    </div>
                  </div>
                </div>
                <div class="card">
                  <div class="card-header" id="headingfour">
                    <button class="btn btn-link collapsed" type="button" data-toggle="collapse"
                      data-target="#collapsefour" aria-expanded="false" aria-controls="collapsefour">
                      Nguồn gốc dịch bệnh COVID-19
                      <i class="fas fa-chevron-down"></i>
                    </button>
                  </div>
                  <div id="collapsefour" class="collapse" aria-labelledby="headingfour" data-parent="#accordionExample">
                    <div class="card-body">
                      <ul class="nav nav-tabs" id="myTab4" role="tablist">
                        <li class="nav-item">
                          <a class="nav-link" id="profile4-tab" data-toggle="tab" href="#profile4" role="tab"
                            aria-controls="profile4" aria-selected="false">Hệ gen của virus Corona 2019 là gì?</a>
                        </li>
                        <li class="nav-item">
                          <a class="nav-link" id="contact4-tab" data-toggle="tab" href="#contact4" role="tab"
                            aria-controls="contact4" aria-selected="false">Vi rút SARS-CoV-2 được phát hiện khi nào?</a>
                        </li>
                        <li class="nav-item">
                          <a class="nav-link" id="four4-tab" data-toggle="tab" href="#four4" role="tab"
                            aria-controls="four4" aria-selected="false">Thời gian ủ bệnh virus SARS-CoV-2</a>
                        </li>
                        <li class="nav-item">
                          <a class="nav-link" id="five4-tab" data-toggle="tab" href="#five4" role="tab"
                            aria-controls="five4" aria-selected="false">Nguyên nhân nhiễm vi rút SARS-CoV-2</a>
                        </li>
                      </ul>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="col-lg-8">
            <div class="tab-content answer_details" id="myTabContent">
              <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                <h4>Virus Corona là gì?</h4>
                <p>
                  Virus Corona 2019 là nhóm các virus thuộc phân họ Coronavirinae trong họ Coronaviridae, của bộ Nidovirales. Coronavirus là hệ gen ARN dương sợi đơn kèm nucleocapsid đối xứng xoắn ốc. Bộ gen của Coronavirus lớn khoảng từ 26 – 32 kilo base.
                </p>
                <p>
                  Tên gọi vi rút Corona 2019 có nguồn gốc từ tiếng Latin, trong đó “corona” có nghĩa là “vương miện” hoặc “hào quang”. Virus này có những chiếc gai bao bọc bên ngoài, chúng tương tác với thụ thể trên tế bào, theo cơ chế tương tự chìa khóa và ổ khóa, từ đó cho phép virus xâm nhập vào bên trong. Virus Corona chủng mới là SARS-CoV-2 chưa từng xuất hiện ở người.
                </p>
              </div>
              <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">
                <h4>Sự khác biệt giữa COVID-19 và bệnh cúm là gì?</h4>
                <p>
                  COVID-19 và bệnh cúm đều là những bệnh truyền nhiễm đường hô hấp do virus gây ra. COVID-19 do virus SARS-CoV-2 gây ra, trong khi bệnh cúm do virus cúm A và B. Những virus này lây lan theo những cách tương tự.
                </p>
                <p>
                 COVID-19 và bệnh cúm gây ra các triệu chứng tương tự. Các bệnh này cũng có thể không gây ra triệu chứng hoặc các triệu chứng nhẹ hoặc nghiêm trọng. Vì có nhiều điểm tương đồng, khó có thể chẩn đoán bạn mắc bệnh nào nếu chỉ dựa vào các triệu chứng. Xét nghiệm có thể được thực hiện để xem liệu bạn có bị nhiễm COVID-19 hay bệnh cúm hay không. Bạn cũng có thể mắc cả hai bệnh cùng một lúc. Tuy nhiên, chúng vẫn có một số khác biệt.
                </p>
                <p>
                  Các triệu chứng COVID-19 thường xuất hiện từ 2 đến 14 ngày sau khi tiếp xúc với SARS-CoV-2. Các triệu chứng cúm thường xuất hiện khoảng 1 đến 4 ngày sau khi tiếp xúc với virus cúm.COVID-19 có thể gây ra các bệnh nghiêm trọng hơn ở một số người so với bệnh cúm. Ngoài ra, COVID-19 có thể gây ra các biến chứng khác với bệnh cúm, chẳng hạn như cục máu đông và hội chứng viêm đa hệ ở trẻ em.
                </p>
                <p>
                  Mặc dù chỉ có một phương pháp điều trị kháng virus COVID-19, nhưng có một số loại thuốc kháng virus có thể được sử dụng để điều trị bệnh cúm. Ngoài ra, bạn có thể tiêm phòng cúm hàng năm để giúp giảm nguy cơ mắc bệnh cúm. Thuốc chủng ngừa cúm cũng có thể làm giảm mức độ nghiêm trọng của bệnh cúm và nguy cơ biến chứng nghiêm trọng. Vaccine có thể được tiêm dưới dạng tiêm hoặc xịt mũi.
                </p>
              </div>
              <div class="tab-pane fade" id="contact" role="tabpanel" aria-labelledby="contact-tab">
                <h4>Virus lây lan như thế nào</h4>
                <p>
                  Các virus nói chung và virus SARS-CoV-2 nói riêng, trong quá trình lưu hành, sau nhiều lần sao chép và nhân bản có thể xuất hiện những biến đổi trong cấu trúc của gen, nghĩa là có sự thay đổi ở một hoặc một số vị trí trên bộ gen di truyền so với bộ gen ban đầu của virus, điều này được gọi là đột biến gen.
                </p>
                <p>
                  Khi quá trình lây nhiễm tăng nhanh, quá trình virus sao chép và nhân bản cũng gia tăng, các đột biến gen của virus có cơ hội xuất hiện nhiều hơn, dẫn đến khả năng xuất hiện biến thể cao hơn. 
                </p>
              </div>
              <div class="tab-pane fade" id="four" role="tabpanel" aria-labelledby="four-tab">
                <h4>Triệu chứng của bệnh COVID-19?</h4>
                <p>
                  Trong giai đoạn đầu của đại dịch, người ta cho rằng sổ mũi không phải là triệu chứng của COVID-19, nhiều khả năng là dấu hiệu của bệnh cúm thông thường. Tuy nhiên, từ dữ liệu của các cuộc nghiên cứu sau này cho thấy, sổ mũi, ngạt mũi, chảy nước mũi có thể xuất hiện ở bệnh nhân COVID-19, đặc biệt là những bệnh nhân nhiễm biến thể Delta.
                </p>
                <p>
                  Sau thời gian ủ bệnh (trong khoảng từ 2 đến 14 ngày), các triệu chứng nhiễm COVID 19 bắt đầu xuất hiện như ho khan và sốt nhẹ. Sốt được xác định nghi ngờ COVID 19 là từ 38,1oC – 39oC hay 100,5oF – 102,1oF, thường kèm theo giảm chức năng vị giác và khứu giác.
                </p>
                <p>
                  Bệnh nhân sẽ được điều trị và cách ly tại nhà nếu các triệu chứng ở mức độ nhẹ hoặc trung bình và tự khỏi trong 1 tuần. Khoảng 10% người bệnh vẫn còn những triệu chứng sốt, mệt mỏi, ho, tiêu chảy… vào tuần thứ hai. Nếu các triệu chứng càng kéo dài càng xuất hiện thêm nhiều triệu chứng tăng nặng, đòi hỏi người bệnh phải nhập viện, hồi sức tích cực và thở máy xâm lấn. COVID 19 có diễn tiến khó đoán, đặc biệt là ở bệnh nhân lớn tuổi có bệnh nền đi kèm. Biểu hiện lâm sàng thay đổi từ hoàn toàn không có triệu chứng đến triệu chứng nặng và tử vong.
                </p>
                <p>
                  Đại dịch COVID-19 do virus SARS CoV 2 chủ yếu gây ra hội chứng hô hấp cấp tính nghiêm trọng. Mặc dù vậy, COVID-19 vẫn được ghi nhận với nhiều biến chứng của COVID-19 thường gặp như nhức đầu, chóng mặt, thay đổi ý thức, rối loạn khứu giác, rối loạn vị giác, co giật và đột quỵ.
                </p>
              </div>
              <div class="tab-pane fade" id="home3" role="tabpanel" aria-labelledby="home3-tab">
                <h4>ự khác nhau giữa mắc COVID-19, cảm lạnh, dị ứng và cảm cúm là gì?</h4>
                <p>
                  Cả COVID-19 và cảm lạnh thông thường đều do virus gây ra. COVID-19 do SARS-CoV-2 gây ra, trong khi cảm lạnh thông thường thường do rhinovirus gây ra. Những virus này lây lan theo những cách tương tự nhau và gây ra nhiều dấu hiệu và triệu chứng giống nhau. Tuy nhiên, có một vài điểm khác biệt.
                </p>
                <p>
                 Trong khi các triệu chứng COVID-19 thường xuất hiện từ 2 đến 14 ngày sau khi tiếp xúc với SARS-CoV-2, các triệu chứng của cảm lạnh thông thường thường xuất hiện từ 1 đến 3 ngày sau khi tiếp xúc với virus gây cảm lạnh.Không có thuốc chữa cảm lạnh thông thường. Điều trị có thể bao gồm thuốc giảm đau và thuốc trị cảm lạnh không kê đơn, chẳng hạn như thuốc thông mũi. Không giống như COVID-19, cảm lạnh thường vô hại. Hầu hết mọi người đều hồi phục sau cảm lạnh thông thường trong vòng 3 đến 10 ngày.
                </p>
              </div>
              <div class="tab-pane fade" id="profile3" role="tabpanel" aria-labelledby="profile3-tab">
                <h4> Triệu chứng gây ra bởi virus SARS-CoV-2 qua từng ngày</h4>
                <p>
                  Tùy theo thể trạng và sức đề kháng, triệu chứng nhiễm corona qua từng ngày của mỗi cá thể là khác nhau, tuy nhiên những triệu chứng này đều biểu hiện rõ từ 2-14 ngày. Do đó, ngay khi có các dấu hiệu nghi ngờ, người bệnh cần đến ngay các cơ sở y tế gần nhất để được chẩn đoán kịp thời.Ngày 1 đến ngày 3:Dấu hiệu giống bệnh cảm thông thườngViêm họng nhẹ, không sốt, không mệt mỏi Ăn uống và hoạt động bình thường.Ngày 4:Cổ họng bắt đầu đau nhẹ, người lờ đờ.Bắt đầu khan tiếng.Nhiệt độ cơ thể tăng nhẹ.Đau đầu nhẹ, tiêu chảy nhẹ.Bắt đầu chán ăn.Ngày 5:Đau họng nhiều hơn, khan tiếng nhiều hơn.Nhiệt độ cơ thể tăng nhẹCơ thể mệt mỏi, đau nhức các khớp xương.Ngày 6:Triệu chứng gây ra bởi virus SARS-CoV-2 là bắt đầu sốt nhẹ.Ho có đàm hoặc ho khan không đàm.Đau họng nhiều hơn, đau khi nuốt nước bọt, khi ăn hoặc nói.Cơ thể mệt mỏi, buồn nôn.Tiêu chảy, có thể nôn ói.Lưng hoặc ngón tay đau nhức.Ngày 7:Sốt cao dưới 38o Ho nhiều hơn, đàm nhiều hơn.Toàn thân đau nhức.Khó thở.Tiêu chảy và nôn ói nhiều hơn.Ngày 8:Sốt khoảng trên dưới 38o.Khó thở, hơi thở khò khè, nặng lồng ngực.Ho liên tục, đàm nhiều, tắt tiếng.Đau khớp xương, đau đầu, đau lưng.Ngày 9:Các tình trạng như sốt, ho, khó thở, nặng lồng ngực… trở nên nặng nề hơn.
                </p>
              </div>
              <div class="tab-pane fade" id="contact3" role="tabpanel" aria-labelledby="contact3-tab">
                <h4>Biểu hiện của bệnh COVID-19 có sổ mũi không? </h4>
                <p>
                  Trong giai đoạn đầu của đại dịch, người ta cho rằng sổ mũi không phải là triệu chứng của COVID-19, nhiều khả năng là dấu hiệu của bệnh cúm thông thường. Tuy nhiên, từ dữ liệu của các cuộc nghiên cứu sau này cho thấy, sổ mũi, ngạt mũi, chảy nước mũi có thể xuất hiện ở bệnh nhân COVID-19, đặc biệt là những bệnh nhân nhiễm biến thể Delta.
                </p>
                <p>
                  Theo báo cáo của Tổ chức Y tế Thế giới (WHO), khoảng 5% bệnh nhân mắc Corona virus có triệu chứng nghẹt mũi. Đây không phải là dấu hiệu phổ biến nhất của bệnh, nhưng đây là triệu chứng dễ gây nhầm lẫn với cảm lạnh và cúm. Trên thực tế, nhiều dấu hiệu COVID 19 giống với bệnh cúm như đau đầu, đau nhức cơ thể, mệt mỏi. Một số triệu chứng khác có thể giống như cảm lạnh hoặc dị ứng, như đau họng, ho, sốt và nghẹt mũi.
                </p>
                <p>
                  Báo cáo đưa ra bởi Tổ chức Y tế Thế giới (WHO) cho thấy, trong số 55.924 người mắc COVID 19 được theo dõi, hơn 33% bệnh nhân có biểu hiện ho ra đờm, chất nhầy dày được tạo ra từ phổi. Triệu chứng ho của COVID 19 không phải là hiện tượng ngứa cổ họng khiến người bệnh hắng giọng, cũng không chỉ là do kích thích, mà cơn ho này xuất phát từ vùng ức và các ống phế quản bị viêm rất khó chịu.
                </p>
                <p>
                  Đau họng, ho khan, thậm chí có đờm đặc và bọt, khả năng cao là một trong những triệu chứng điển hình, nghiêm trọng và phổ biến của COVID-19. Dấu hiệu COVID đau họng thường dễ bị nhầm lẫn với đau họng thông thường. Đau họng do bệnh COVID không có hiệu quả điều trị khi uống các thuốc đau họng thông thường. Do đó, nếu cảm thấy ho nhiều, kéo dài, uống thuốc hoặc điều trị tại nhà không đỡ, kết hợp với triệu chứng sốt, khó thở, người bệnh cần đi khám sức khỏe ngay tại các cơ sở khám, chữa bệnh được Nhà nước, Bộ Y tế chỉ định.
                </p>
              </div>
              <div class="tab-pane fade" id="four3" role="tabpanel" aria-labelledby="four3-tab">
                <h4>Biểu hiện sớm nhất của bệnh COVID-19 gây ra bởi virus SARS-CoV-2 là gì?</h4>
                <p>
                  Theo cảnh báo từ Trung tâm Kiểm soát và Phòng ngừa dịch bệnh Hoa Kỳ (CDC Hoa Kỳ), khi mắc COVID 19, một hoặc tất cả các triệu chứng đều có thể xuất hiện bất cứ lúc nào trong vòng 2-14 ngày sau khi tiếp xúc với virus SARS-CoV-2. Theo đó, các biểu hiện sớm nhất để phát hiện bệnh là:
                </p>
                <p>
                <ul>
                  <il> Sốt: Sốt là dấu hiệu nhận biết corona đầu tiên. Hầu hết trẻ em và người lớn sẽ được xác định là sốt khi nhiệt độ vượt mức 38oC. Các chuyên gia khuyến cáo, bệnh nhân không nên dựa vào nhiệt độ đo buổi sáng vì sốt do virus thường khiến thân nhiệt tăng vào cuối buổi chiều và đầu buổi tối.</il>
                  <il>Ho khan: Ho là một triệu chứng COVID 19 sớm và phổ biến nhất. Ho do COVID 19 gây ra sẽ không thể điều trị dứt điểm khi uống thuốc ho thông thường. </il>
                  <il>Mệt mỏi: Mệt mỏi, kiệt sức, đau nhức cơ thể là biểu hiện COVID 19 sớm. Nghiên cứu của WHO cho thấy, khoảng 40% trong số gần 6.000 người mắc bệnh trải qua giai đoạn mệt mỏi. Trạng thái này thậm chí còn kéo dài ngay sau khi COVID 19 kết thúc một vài tuần. </il>
               </ul>
             </p>
              </div>
              <div class="tab-pane fade" id="five3" role="tabpanel" aria-labelledby="five3-tab">
                <h4>Triệu chứng của COVID-19 có nghẹt mũi không?</h4>
                <p>
                  Theo báo cáo của Tổ chức Y tế Thế giới (WHO), khoảng 5% bệnh nhân mắc Corona virus có triệu chứng nghẹt mũi. Đây không phải là dấu hiệu phổ biến nhất của bệnh, nhưng đây là triệu chứng dễ gây nhầm lẫn với cảm lạnh và cúm. Trên thực tế, nhiều dấu hiệu COVID 19 giống với bệnh cúm như đau đầu, đau nhức cơ thể, mệt mỏi. Một số triệu chứng khác có thể giống như cảm lạnh hoặc dị ứng, như đau họng, ho, sốt và nghẹt mũi.
                </p>  
              </div>
              <div class="tab-pane fade" id="profile4" role="tabpanel" aria-labelledby="profile4-tab">
                <h4>Hệ gen của virus Corona 2019 là gì?</h4>
                <p>
                  Bộ gen của virus Corona 2019 là bộ gen lớn nhất trong số các virus RNA, bao gồm các vùng: vùng 5’UTR, khung đọc mở, vùng 3’UTR và cuối cùng là đuôi-poly (A).
                </p>
                <p>
                  Theo các nghiên cứu, bộ gen của virus Corona 2019 có các mặt tương đồng như sau:
                </p>
                <ul>
                  <il>Tương đồng 50% mã gen so với chủng virus MERS-CoV;</il>
                  <il>Tương đồng 79,5% mã gen so với chủng virus SARS-CoV;</il>
                  <il>Tương đồng 96% mã gen so với chủng virus Corona được phát hiện trong dơi, đặc biệt là dơi móng ngựa;</il>
                  <il>Tương đồng 99% mã gen so với chủng virus Corona có trong loài Tê tê.</il>
                </ul>
                <p>
                  Khi phân tích vi rút Corona 2019, các nhà khoa học nhận thấy vi rút Corona cùng loài với virus gây bệnh SARS vào năm 2003 với độ tương đồng lên đến 94.6% các chuỗi axit amin.
                </p>
                <p>
                  Trong bộ gen của vi rút Corona 2019 có một gen thiết yếu là RdRp (RNA phụ thuộc RNA polymerase), gen này có độ bảo tồn cao, được dùng để chẩn đoán phát hiện vi rút Corona.
                </p>
              </div>
              <div class="tab-pane fade" id="contact4" role="tabpanel" aria-labelledby="contact4-tab">
                <h4>
                 Vi rút SARS-CoV-2 được phát hiện khi nào?
                </h4>
                <p>
                  Bùng phát vào cuối tháng 12/2019, bắt nguồn từ một chợ hải sản ở Hồ Nam, Vũ Hán, miền Trung Trung Quốc, virus SARS-CoV-2 ban đầu được xác nhận là một loại bệnh “viêm phổi lạ” hoặc “viêm phổi không rõ nguyên nhân”. Chỉ sau 100 ngày xuất hiện, đại dịch viêm đường hô hấp cấp do virus SARS-CoV-2 đã nhanh chóng tác động tới các lĩnh vực kinh tế, xã hội, thị trường tài chính chao đảo, nền kinh tế toàn cầu rơi vào suy thoái với tỷ lệ thất nghiệp và nghèo đói chưa từng có trong lịch sử.
                </p>
                <p>
                  Cho đến nay, đã có 215 quốc gia, vùng lãnh thổ (trong đó có 2 tàu du lịch) ghi nhận ca mắc COVID-19.
                </p>
                
              </div>
              <div class="tab-pane fade" id="four4" role="tabpanel" aria-labelledby="four4-tab">
                <h4>Thời gian ủ bệnh virus SARS-CoV-2</h4>
                <p>
                  Theo CDC Mỹ, các triệu chứng COVID-19 thường xuất hiện từ ngày thứ 2 – 14 sau khi nhiễm virus tùy thuộc vào từng cá thể, trung bình là 5 ngày. Riêng với biến thể Delta, thời gian ủ bệnh ngắn, chỉ khoảng 2 – 4 ngày. Trong thời gian này, virus vẫn có thể truyền bệnh cho người khác
                </p>
                <p>
                  1. Đối với Coronavirus :Các ước tính hiện tại cho thấy, các chủng virus Corona chẳng hạn như MERS và SARS có thời gian ủ bệnh khoảng 2-11 ngày. Giống như các bệnh về đường hô hấp khác, sau khi hết giai đoạn ủ bệnh, người nhiễm Coronavirus sẽ xuất hiện các triệu chứng gồm sổ mũi, đau họng, ho và sốt… Bệnh có thể diễn tiến nặng ở một số người khi gây ra viêm phổi cấp. Nguy hiểm hơn, Covid-19 có thể nhanh chóng gây tử vong cho đối tượng nguy cơ cao như người già, người mắc bệnh mạn tính (tiểu đường, tim mạch, ung thư, viêm phổi tắc nghẽn mãn tính COPD…).
                </p>
                <p>
                  2. Đối với chủng mới: Viêm đường hô hấp cấp do virus Corona chủng mới có thể xuất hiện các triệu chứng sau thời gian ủ bệnh kéo dài từ 2 đến 14 ngày, trung bình là 5 ngày. Trong thời gian này, virus vẫn có thể truyền bệnh cho người khác. Mặc dù vậy, nhiều nghiên cứu cũng chỉ ra rằng, sẽ có một số ít trường hợp thời gian ủ bệnh Sars-Cov 2 có thể kéo dài hơn 14 ngày. Nghiên cứu  được thực hiện bởi Trường Y tế Cộng đồng Johns Hopkins Bloomberg (Mỹ) cho thấy, trong số 10.000 đối tượng bị nhiễm Covid-19 thì có khoảng 101 trường hợp xuất hiện các triệu chứng đầu tiên sau 14 ngày. Do đó, các chuyên gia cho rằng các việc tiếp xúc với người không có biểu hiện bệnh không có nghĩa là an toàn. Nói cách khác, Covid-19 có thể lây nhiễm ngay cả trước khi các triệu chứng đầu tiên xuất hiện.
                </p>
              </div>
              <div class="tab-pane fade" id="five4" role="tabpanel" aria-labelledby="five4-tab">
                <h4>Nguyên nhân nhiễm vi rút SARS-CoV-2</h4>
                <p>
                  Người bị nhiễm virus SARS-CoV-2 là từ người tiếp xúc với các giọt dịch hô hấp của cơ thể của người có mầm bệnh khi hắt hơi, ho hoặc thở ra. Các nhà khoa học và quan chức có trách nhiệm đã xác nhận ba cách lây truyền: truyền trực tiếp, truyền tiếp xúc và truyền khí dung.
                <p>
                  Trung tâm kiểm soát và phòng ngừa dịch bệnh Hoa Kỳ (CDC) đã đưa ra danh sách những người có nguy cơ cao nhất nhiễm vi rút Corona. Đây là nhóm đối tượng cực kỳ nhạy cảm và dễ tử vong do virus Corona gồm cả trẻ em, người lớn, người cao tuổi, phụ nữ có thai, người có tiền sử bệnh, người bị suy giảm miễn dịch hoặc có các bệnh lý nền (bệnh tim, bệnh phổi mạn tính, suy giảm miễn dịch, béo phì, đái tháo đường…).
                </p>
                <p>
                  Người bệnh có thể lây truyền virus ngay cả khi họ không có triệu chứng điển hình. Cần xác định người bệnh bằng xét nghiệm, cách ly, và chăm sóc y tế, tùy thuộc vào mức độ nghiêm trọng. Thậm chí, người đã được xác định mắc COVID-19 nhưng không biểu hiện triệu chứng cũng cần được cách ly và thực hiện nghiêm túc các biện pháp giãn cách, kiểm soát để hạn chế tiếp xúc với người khác nhằm ngăn chặn sự lây lan của bệnh.  
                </p>
                
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
    <!--================End Answers Area =================-->

    <!--================Home Latest Blog Area =================-->
    <section class="home_latest_blog_area">
      <div class="container">
        <div class="main_title text-center">
          <h5>Các tin tức nổi bật</h5>
          <h2>Tin tức nổi bật gần đây</h2>
          <p>
            Tìm hiểu tin tức hàng ngày về COVID-19.


          </p>
        </div>
        <div class="row l_blog_inner">
        <?php
    //1.ket noi den MAY CHU DU LIEU & DEN CSDL
    include('config.php');

    //2.Viet cau lenh truy vấn tin tức nhiều người xem nhất
        $sql2=" SELECT *
              FROM tbl_tin_tuc
              JOIN tbl_tin_tuc_hashtag 
              ON tbl_tin_tuc.hashtag_id=tbl_tin_tuc_hashtag.hashtag_id 
              WHERE so_lan_doc = (SELECT MAX(so_lan_doc) FROM tbl_tin_tuc ORDER BY tin_tuc_id DESC ) ";
    //3.Thuc thi cau lenh truy van(muc dich tra ve du lieu cac ban can) 

        $noi_dung_tin_tuc2=mysqli_query($ket_noi, $sql2);

    //4.Hien thi ra du lieu ma cac ban vua lay duoc
        $row2=mysqli_fetch_array($noi_dung_tin_tuc2);

        ?>
          <div class="col-lg-8">
            <div class="big_l_blog_item">
              <div class="l_blog_img">
              <img style="width: 770px; height: 430px;"
              class="img-fluid" src="<?php echo $row2['anh_minh_hoa'] ? 'images/blog/blog-grid/'.$row2['anh_minh_hoa'] :'images/blog/blog-grid/blog-1.jpeg';?>" alt="" />
              </div>
              <div class="l_blog_text">
                <div class="date">
                  <a href="#"><i class="far fa-calendar-alt"></i> <?php echo date("d/m/Y ",strtotime($row2["ngay_dang_tin"]));?> </a>
                  <a href="#"><i class="far fa-eye"></i>  <?php echo $row2["so_lan_doc"];?> lượt đọc</a>
                </div>
                <div class="blog_btm_text">
                  <div class="tag"><?php echo $row2["ten_hashtag"];?></div>
                  <div class="author">
                    <a href="#">by <?php echo $row2["tac_gia"];?></a>
                  </div>
                  <a href="#">
                    <h3><?php echo $row2["tieu_de"];?></h3>
                  </a>
                  <a class="text_btn" style="text-align: center;"  href="single-blog.php?id=<?php echo $row2['tin_tuc_id'];?>">Đọc thêm 
                  <i class="fas fa-arrow-right"></i>
                </div>
              </div>
            </div>
          </div>
          <?php 
      //5.Dong ket noi sau khi su dung
        mysqli_close($ket_noi);
       ;?>
          <div class="col-lg-4">
          <?php 
                    // 1. Load file cấu hình để kết nối đến máy chủ CSDL, CSDL
                    include('config.php');

                    // 2. Viết câu lệnh truy vấn để lấy ra được DỮ LIỆU MONG MUỐN (TIN TỨC đã lưu trong CSDL)
                    //truy vấn tin tức mới nhất
        
                    $sql1=" SELECT * FROM tbl_tin_tuc 
                    JOIN tbl_tin_tuc_hashtag 
                    ON tbl_tin_tuc.hashtag_id=tbl_tin_tuc_hashtag.hashtag_id 
                    ORDER BY tin_tuc_id DESC LIMIT 2";

                    // 3. Thực thi câu lệnh truy vấn (mục đích trả về dữ liệu các bạn cần)
                    $noi_dung_tin_tuc1=mysqli_query($ket_noi, $sql1);

                    // 4. Hiển thị ra dữ liệu mà các bạn vừa lấy được
                    
                    while ($row1 = mysqli_fetch_array($noi_dung_tin_tuc1)) 
                    {
                    ;?>
                        <div class="small_l_blog_item">
                          <div class="l_blog_img">
                            
                            <img style="width: 370px; height: 200px;"
                            src="<?php echo $row1['anh_minh_hoa'] ? 'images/blog/blog-grid/'.$row1['anh_minh_hoa'] :'images/blog/blog-grid/blog-1.jpeg';?>" />
                          </div>
                          <div class="l_blog_text">
                            <div class="date">
                              <a href="#"><i class="far fa-calendar-alt"></i> <?php echo date("d/m/Y ",strtotime($row1["ngay_dang_tin"]));?></a>
                              <a href="#"><i class="far fa-eye"></i> <?php echo $row1["so_lan_doc"];?> lượt đọc</a>
                            </div>
                            <a href="#">
                              <h6 style="color:white"><?php echo $row1["tieu_de"];?></h6>
                            </a>
                            <a class="text_btn" style="text-align: center;"  href="single-blog.php?id=<?php echo $row1['tin_tuc_id'];?>">Đọc thêm 
                                      <i class="fas fa-arrow-right"></i>
                          </div>
                        </div>
                    <?php 
                    }
                    // 5. Đóng kết nối sau khi sử dụng xong
                    mysqli_close($ket_noi);
                ;?>
            
          </div>
        </div>
      </div>
      <?php 
       ;?>
    </section>
    <!--================End Home Latest Blog Area =================-->

    <!--================Client Logo Area =================-->
    <section class="client_logo_area">
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
                        mysqli_close($ket_noi);
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