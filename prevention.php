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
    <link rel="stylesheet" href="vendors/linearicons/css/linearicons.css" />
    <link rel="stylesheet" href="vendors/animate-css/animate.css" />
    <link rel="stylesheet" href="vendors/slick/slick.css" />
    <link rel="stylesheet" href="vendors/slick/slick-theme.css" />
    <link rel="stylesheet" href="vendors/mCustomScrollbar/jquery.mCustomScrollbar.min.css" />

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
              <li><a href="index.html">Trang chủ</a></li>
              <li>
                <a href="index.html">Phòng chống
                  <i class="linearicons-chevron-down"></i>
                </a>
                <ul class="list">
                  <li><a href="symptom.html">Các triệu chứng phổ biến</a></li>
                  <li><a href="symptom-checker.html">Trình kiểm tra triệu chứng</a></li>
                  <li><a href="prevention.html">Biện pháp phòng chống</a></li>
                  <li><a href="tracker.html">Bản đồ dịch tễ Hà Nội</a></li>
                  <li><a href="faq.html">FAQs</a></li>
                </ul>
              </li>
              <li><a href="appointment.html">Tư vấn</a></li>
              <li>
                <a href="#">Giới thiệu
                  <i class="linearicons-chevron-down"></i>
                </a>
                <ul class="list">
                  <li><a href="about.html">Corona Virus</a></li>
                  <li><a href="doctors.html">Đội ngũ bác sĩ</a></li>
                  <li><a href="sample-right-sidebar.html">Vaccien Phòng COVID-19 </a></li>
                  <li><a href="search.html">Tìm kiếm</a></li>
                </ul>
              </li>

                    <li>
                        <a href="index.html">Tin tức
                            <i class="linearicons-chevron-down"></i>
                        </a>
                        <ul class="list">
                            <li><a href="blog.html">Tin tức</a></li>
                            <li><a href="single-blog.html">Tin tức chi tiết</a></li>

                        </ul>
                    </li>
                    <li><a href="contact.html">Liên hệ<</a></li>
                </ul>
            </div>
            <div class="menu_btm">
                <a class="green_btn" href="#"><i class="linearicons-pulse"></i>Kiểm tra triệu chứng</a>
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
                                <input class="form-control" type="text" id="a_name" name="a_name" placeholder=""
                                    required />
                                <label><i class="linearicons-user"></i>Họ và tên</label>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <div class="form-group">
                                <input class="form-control" type="text" id="a_email" name="a_email" placeholder=""
                                    required />
                                <label><i class="linearicons-envelope-open"></i>Email</label>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <div class="form-group">
                                <input class="form-control" type="text" id="a_number" name="a_number" placeholder=""
                                    required />
                                <label><i class="linearicons-telephone"></i>số điện thoại </label>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <div class="form-group">
                                <textarea name="a_message" id="a_message" cols="30" rows="10" class="form-control"
                                    required></textarea>
                                <label><i class="linearicons-document"></i>Nội dung</label>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <div class="form-group checkbox_field">
                                <div class="checkbox">
                                    <input type="checkbox" value="None" id="a_policy" name="check" />
                                    <label class="l_text" for="a_policy">Tôi chấp nhận <span>Chính sách bảo mật</span></label>
                                </div>
                                <button type="submit" class="green_btn" name="appoinment" id="appoinment"
                                    value="appoinment" data-value="appoinment">
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
                        </script> Epidemic .
                    </p>
                </div>
            </div>
        </section>
        <!--================End Sidebar Form Area =================-->

        <!--================Header Area =================-->
        <header class="header_area white_header">
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
            <a class="navbar-brand" href="index.html">
                <img src="images/logo-22.png" srcset="images/logo-2-2x2.png 2x" alt="" />
                <img src="images/logoo.png" srcset="images/logo-2xx.png 2x" alt="" />
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent"
              aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="nav navbar-nav ml-auto">
                <li ><a href="index.php ">Trang chủ</a></li>
                  <li class="dropdown submenu active">
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
                <li>
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
                        <img src="images/icon/search-white.png" alt="" />
                        <img src="images/icon/search.png" alt="" />
                    </div>
                </li>
                <li>
                    <div class="menu_btn">
                        <img src="images/icon/burger-white.png" alt="" />
                        <img src="images/icon/burger.png" alt="" />
                    </div>
                </li>
            </ul>
        </div>
      </div>
        </header>
        <!--================End Header Area =================-->

        <!--================Prevention Banner Area =================-->
        <section class="prevention_banner">
            <div class="container">
                <div class="prevention_text">
                    <h6 class="wow fadeInUp">Bạn cần làm gì</h6>
                    <h3 class="wow fadeInUp" data-wow-delay="0.2s">Làm thế nào để ngăn chặn COVID-19?</3>
                    <ul class="nav justify-content-center wow fadeInUp" data-wow-delay="0.3s">
                        <li><a href="index.html">Trang chủ</a></li>
                        <li><a href="prevention.html">Phòng chống</a></li>
                        <li><a href="#">Làm thế nào để ngăn chặn COVID-19?</a></li>
                    </ul>
                    <img class="img-fluid" src="images/breadcrumb/prevention-persong.png" alt="">
                </div>
            </div>
        </section>
        <!--================Home Prevention Banner Area =================-->

        <!--================Protect Yourself Area =================-->
        <section class="protect_yourself_area p_100">
            <div class="container">
                <div class="main_title_2 text-center">
                    <h2 class="wow fadeInUp"> <span>Giãn cách xã hội</span> để giữ an toàn</h2>
                    <p class="wow fadeInUp" data-wow-delay="0.2s">Với số lượng trường hợp mắc COVID-19 tăng lên mỗi ngày, các nhà tâm lý học đưa ra những hiểu biết sâu sắc về tự giữ khoảng  cách với những người khác, mà vẫn nhận được sự hỗ trợ xã hội.</p>
                </div>
                <div class="row protect_inner flex-row-reverse">
                    <div class="col-lg-6">
                        <div class="main_title">
                            <h5>Bạn cần làm gì </h5>
                            <h2>để tự bảo vệ bản thân</h2>
                        </div>
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
                                        <h3>Bạn nên tránh</h3>
                                        <h6>Bạn làm theo </h6>
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
                    </div>
                    <div class="col-lg-6">
                        <div class="protect_img">
                            <img class="img-fluid" src="images/protect-img-2.png" alt="" />
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--================End Protect Yourself Area =================-->

        <!--================Prevent Area =================-->
        <section class="prevent_area prevent_right">
            <div class="container">
                <div class="row prevent_inner flex-row-reverse">
                    <div class="col-lg-6">
                        <div class="prevent_item_inner row">
                            <div class="col-sm-6">
                                <div class="prevent_item wow fadeInUp">
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
                            <div class="col-sm-6">
                                <div class="prevent_item wow fadeInUp" data-wow-delay="0.2s">
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
                            <div class="col-sm-6">
                                <div class="prevent_item wow fadeInUp" data-wow-delay="0.4s">
                                    <div class="prevent_img">
                                        <img class="img-fluid" src="images/prevent/prevent-3.png" alt="" />
                                    </div>
                                    <div class="prevent_text">
                                        <h4>Giãn cách xã hội</h4>
                                        <p>
                                            Giữ khoảng cách ít nhất 2 m giữa bạn và bất kỳ ai nếu bạn đi giữa mọi người.
                                        </p>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="prevent_item wow fadeInUp" data-wow-delay="0.6s">
                                    <div class="prevent_img">
                                        <img class="img-fluid" src="images/prevent/prevent-4.png" alt="" />
                                    </div>
                                    <div class="prevent_text">
                                        <h4>Đeo khẩu trang</h4>
                                          <p></h4>
                                        <p>
                                            Bất kì khi nào, bạn ở gần những người khác và trước khi bạn đến các trung tâm y tế.
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
                                    Một số thông tin về cách thức lây lan của căn bệnh này đã<br> được xác định. WHO và CDC tuyên bố rằng căn bệnh này <br> chủ yếu lây lan khi tiếp xúc gần và do các giọt bắn tạo ra<br> khi người ta ho hoặc hắt hơi; tiếp xúc gần trong vòng 1 đến <br> 2 mét. Một nghiên cứu ở Singapore phát hiện ra rằng một<br> cơn ho khi không đeo khẩu trang hay che tay có thể  dẫn <br>  đến những giọt bắn bay đến 4,5 mét.
                                <p>
                                    Các giọt bắn qua hô hấp cũng có thể được tạo ra trong<br> quá trình thở ra, kể cả khi nói chuyện, mặc dù vi-rút nói <br> chung không lây nhiễm trong không khí. Những giọt này<br> có thể rơi vào miệng hoặc mũi của những người ở gần đó<br> hoặc có thể bị hít vào phổi...
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--================End Prevent Area =================-->

        <!--================Washing Process Area =================-->
        <section class="washing_process_area pad_btm">
            <div class="container">
                <div class="main_title text-center white">
                    <h5>Quy trình rửa tay</h5>
                    <h2>Rửa tay đúng cách</h2>
                </div>
                <div class="washing_process_inner row">
                    <div class="col-lg-2 col-sm-4 col-6">
                        <div class="washing_item wow fadeIn" data-wow-delay="400ms">
                            <div class="icon">
                                <img src="images/icon/washing-1.png" alt="" />
                                <div class="number">
                                    1
                                </div>
                            </div>
                            <p><span>Thoa xà phòng</span> và xoa hai tay lại với nhau</p>
                        </div>
                    </div>
                    <div class="col-lg-2 col-sm-4 col-6">
                        <div class="washing_item wow fadeIn" data-wow-delay="500ms">
                            <div class="icon">
                                <img src="images/icon/washing-2.png" alt="" />
                                <div class="number">
                                    2
                                </div>
                            </div>
                            <p>
                                <span>Dùng một tay</span> xoa mu bàn tay kia và ngược lại.
                            </p>
                        </div>
                    </div>
                    <div class="col-lg-2 col-sm-4 col-6">
                        <div class="washing_item wow fadeIn" data-wow-delay="600ms">
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
                    <div class="col-lg-2 col-sm-4 col-6">
                        <div class="washing_item wow fadeIn" data-wow-delay="700ms">
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
                    <div class="col-lg-2 col-sm-4 col-6">
                        <div class="washing_item wow fadeIn" data-wow-delay="800ms">
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
                    <div class="col-lg-2 col-sm-4 col-6">
                        <div class="washing_item wow fadeIn" data-wow-delay="900ms">
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