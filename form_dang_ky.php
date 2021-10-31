<?php 
session_start();
if(isset($_GET['loai_id']))
{
  $loai_id = $_GET['loai_id'];
  include('config.php');
}
else
//header('location: index.php');
?>
<!-- Copy đoạn này -->
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
          <li class="active">
            <a href="index.html">Phòng chống
              <i class="linearicons-chevron-down"></i>
            </a>
            <ul class="list">
              <li><a href="symptom.php">Các triệu chứng thường gặp</a></li>
              <li><a href="symptom-checker.php">Kiểm tra triệu chứng</a></li>
              <li><a href="prevention.php">Biện pháp phòng chống</a></li>
              <li><a href="tracker.php">Theo dõi tình hình</a></li>
            </ul>
          </li>
          <li><a href="appointment.php">Tư vấn</a></li>
          <li>
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
          <h2>Liên lạc</h2>
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
                  <li class="dropdown submenu active">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="prevention.php" role="button"
                       aria-haspopup="true" aria-expanded="false">Phòng chống </a>
                      <i class="fas fa-angle-down" aria-hidden="true" data-toggle="dropdown"></i>                                  
                        <ul class="dropdown-menu">
                          <li><a href="symptom.php">Các triệu chứng phổ biến</a></li>
                          <li><a href="symptom-checker.php">Đăng Ký Test COVID</a></li>
                          <li><a href="prevention.php">Biện pháp phòng chống</a></li>
                          <li><a href="tracker.php">Theo dõi tình hình</a></li>
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
                  <a href="symptom-checker.php"></i>Kiếm tra triệu chứng</a>
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
<!-- FORM TỪ ĐÂY NHÉ -->
<!--================Breadcrumb Area =================-->
<section class="breadcrumb_area boi_breadcrumb">
      <div class="container">
        <div class="breadcrumb_text">
          <h6 class="wow fadeInUp"></h6>
          <h3 class="wow fadeInUp" data-wow-delay="0.2s">Đăng ký xét nghiệm COVID-19</h3>
          <ul class="nav justify-content-center wow fadeInUp" data-wow-delay="0.3s">
            <li><a href="index.php">Trang chủ</a></li>
            <li><a href=".php">T..........</a></li>
          </ul>
        </div>
        <div class="">
          <div class="col-lg-12 appoinment_features">
            <form class="form form-horizontal" method="post" action="thuc_hien_thanh_toan.php" ">
                        <div class="row mt_15">
                            <div class="col-sm-6 col-xs-12">
                                <div class="form-group ">
                                    <label for="txtHoTen">HỌ TÊN ĐẦY ĐỦ VIẾT HOA</label>
                                      <input name="txtHoTen" type="text" value="" class="form-control" id="txtHoTen" placeholder="HỌ TÊN ĐẦY ĐỦ VIẾT HOA" required>
                                </div>
                            </div>
                            <div class="col-sm-6 col-xs-12">
                                <div class="form-group ">
                                    <label for="txtDienThoai">Số di động *</label>
                                      <input  name="txtDienThoai" value="" type="Phone" class="form-control" id="txtDienThoai" placeholder="Số di động" required>
                                </div>
                            </div>
                        </div>
                        <div class="row mt_5">
                            <div class="col-sm-6 col-xs-12">
                                <div class="form-group ">
                                <label>Ngày sinh *</label>
                                    <div class="form-group input-group date" id="datetimepicker3" data-target-input="nearest">
                                      <div class="input-group-append" data-target="#datetimepicker3" data-toggle="datetimepicker">
                                        <div class="input-group-text">
                                          <i class="far fa-calendar-alt"></i>
                                        </div>
                                      </div>
                                      <input type="text" name="datetimepicker3" class="form-control datetimepicker-input" data-target="#datetimepicker3"
                                        data-toggle="datetimepicker" required="" />
                                    </div>    
                                </div>
                            </div>
                            <div class="col-sm-6 col-xs-12">
                                <div class="form-group ">
                                    <label for="txtQuocTich">Quốc tịch *</label>
                                    <input name="txtQuocTich" value="" type="text" class="form-control" id="txtQuocTich" placeholder="Nhập quốc tịch" required>
                                </div>
                            </div>
                        </div>
                        <div class="row mt_5">
                            <div class="col-sm-6 col-xs-12">
                                <label for="txtGioiTinh">Giới tính *</label>
                                <div>
                                    <div class="radio div_inline">
                                        <label>
                                            <input type="radio" name="txtGioiTinh" id="txtGioiTinh" class="txtGioiTinh" value="Nam" checked>
                                            Nam
                                        </label>
                                    </div>
                                    <div class="radio div_inline">
                                        <label>
                                            <input type="radio" name="txtGioiTinh" id="txtGioiTinh" class="txtGioiTinh" value="Nữ">
                                            Nữ
                                        </label>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6 col-xs-12 mt_15mb">
                                <div class="form-group ">
                                    <label for="txtEmail">Email người liên hệ </label>
                                      <input name="txtEmail" value="" type="email" class="form-control" id="txtEmail" placeholder="Email người liên hệ" required>
                                </div>
                            </div>
                        </div>
                        <div class="row mt_5">
                            <div class="col-sm-6 col-xs-12">
                                <div class="form-group ">
                                    <label for="txtDuong">Số nhà, tên đường*</label>
                                    <input name="txtDuong" type="text" class="form-control" id="txtDuong" placeholder="Số nhà, tên đường" required>
                                </div>
                            </div>
                            <div class="col-sm-6 col-xs-12">
                                <div class="form-group" >
                                    <label for="txtTinhThanh">Thành phố/Tỉnh *</label>
                                    <input type="text" name="txtTinhThanh" class="form-control" placeholder="Tỉnh/Thành phố" required>
                                </div>
                            </div>
                        </div>
                        <div class="row mt_5">
                            <div class="col-sm-6 col-xs-12">
                                <div class="form-group ">
                                    <label for="txtQuanHuyen">Quận/Huyện *</label>
                                    <div id="div_district_cn">
                                        <input type="text" name="txtQuanHuyen" class="form-control" placeholder="Nhập Quận/Huyện">
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6 col-xs-12">
                                <div class="form-group " >
                                    <label for="txtPhuongXa">Phường/Xã*</label>
                                    <div id="div_ward_cn">
                                        <input type="text" class="form-control" name="txtPhuongXa" placeholder="Nhập Phường/Xã">
                                        </select>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="w100 mt_15 mb_15" style="border: 0.5px solid #BFBFBF;"></div>
                        <label>THÔNG TIN DỊCH VỤ</label>
                        <div class="row mt_5">
                            <div class="col-sm-6 col-xs-12">
                                <div class="form-group ">
                                    <label for="txtNgayXN">Ngày dự kiến lấy mẫu *</label>
                                    <input  name="txtNgayXN" type="date" class="form-control" id="txtNgayXN" placeholder="dd/mm/yyyy">
                                </div>
                            </div>
                            <div class="col-sm-6 col-xs-12">
                                <div class="form-group ">
                                    <label for="txtDiaChi">Địa điểm lấy mẫu xét nghiệm *</label>
                                    <select class="form-control" name="txtDiaChi" id="txtDiaChi">
                                        <option value="Trung tâm y tế" selected>Trung tâm y tế</option>
                                        <option value="Tại địa chỉ nhà" selected>Tại địa chỉ nhà</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                        <?php  
                        include('config.php');
                        $sql= " SELECT * FROM `tbl_loai_xet_nghiem` 
                                WHERE `tbl_loai_xet_nghiem`.`loai_id` = '".$loai_id."'
                                ";
                        $ket_qua = mysqli_query($ket_noi,$sql);
                        $row= mysqli_fetch_array($ket_qua);
                        ?>
                        <div class="w100 mt_15 mb_15" style="border: 0.5px solid #BFBFBF;"></div>
                        <div class="mt_25 mb_5"><label>LOẠI XÉT NGHIỆM COVID-19</label></div>
                        <div class="div_listpayment mb_25">
                            <div class="radio item_pay pay_pcr">
                            <input type="hidden" value="<?= $row['loai_id']?>" name="loai_id" />

                              <li><?php echo $row['ten_loai'] ?> <i>(Bạn đã chọn)</i></li>
                            <input type="hidden" value="<?= $row['gia']?>" name="gia" />
                                <strong> <?php echo $row['gia'] ?>đ</strong>
                            </div>

                       
                        <div class="w100 mt_15 mb_15" style="border: 0.5px solid #BFBFBF;"></div>
                        <div class="mt_25 mb_5"><label>HÌNH THỨC THANH TOÁN</label></div>
                        <div class="div_listpayment mb_25">
                            <div class="radio item_pay pay_pcr">
                                <label class="mt_10 mb_10">
                                    <input type="radio" name="txtThanhToan" class="txtThanhToan" value="cod" checked>
                                    <strong class="">Thanh toán bằng tiền mặt tại Địa điểm lấy mẫu.</strong>
                                    <div class="payment_des desc_cod "></div>
                                </label>
                            </div>
                            <div class="radio item_pay">
                                <label class="mt_10 mb_10">
                                    <input type="radio" name="txtThanhToan" class="txtThanhToan" value="qrcode" >
                                    <strong class="">Thanh toán bằng VNPAY QR.<br></strong>
                                </label>
                            </div>
                            
                        <div class="col-sm-6 col-xs-12">
                            <div class="col-xs-8" >
                                <label>Nhận kết quả *</label>
                                <div class="content_loaidichvu">
                                    <div class="radio">
                                        <label>
                                            <input type="radio" name="txtnhankq" id="txtnhankq" class="txtnhankq" value="Trực tiếp" checked> Trực tiếp
                                        </label>
                                        <div class="radio"></div>
                                        <label class="mt_5 " >
                                            <input type="radio" name="txtnhankq" id="txtnhankq" class="txtnhankq" value="Qua email" > Qua email
                                        </label>
                                    </div>
                                </div>
                            </div>
                        </div>

                
                <div class="box_dieukhoan">
                    <div class="div_flex top mb_5 checkbox">
                        <label>
                            <span class="item"><input type="checkbox" name="txtdongy" id="txtdongy"></span>
                            <span class=" lh_12 pl_10">Xét nghiệm là dịch vụ độc lập, không phải là xác nhận được mời tiêm vắc xin</span>
                        </label>
                    </div>
                </div>
                 <button type="submit" class="exit_btn" data-dismiss="modal">ĐĂNG KÝ NGAY</button>
            </form>
          </div>
        </div>
      </div>
    </section>
    <!--================End Breadcrumb Area =================-->
<!-- ĐẾN ĐÂY -->
    <!--================Starrt Work Area =================-->
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
                                   Hãy thử một bài kiểm tra đơn giản để biết bạn có bị lây nhiễm không.
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="right">
                        <a class="icon_btn wow fadeInRight" href="symptom-checker.php">Kiểm tra ngay<i class="far fa-arrow-right"></i></a>
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