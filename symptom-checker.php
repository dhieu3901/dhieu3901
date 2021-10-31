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
    <link rel="stylesheet" href="vendors/slick/slick.css" />
    <link rel="stylesheet" href="vendors/slick/slick-theme.css" />
    <link rel="stylesheet" href="vendors/fontawesome/css/all.min.css" />
    <link rel="stylesheet" href="vendors/linearicons/css/linearicons.css" />
    <link rel="stylesheet" href="vendors/mCustomScrollbar/jquery.mCustomScrollbar.min.css" />
    <link rel="stylesheet" href="vendors/animate-css/animate.css" />

    <!-- Extra Plugin CSS -->
    <link href="vendors/taging-js/tagsinput.css" rel="stylesheet" />
    <link href="vendors/nice-selector/css/nice-select.css" rel="stylesheet" />

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
                <a href="index.php">Phòng chống
                <i class="linearicons-chevron-down"></i>
                </a>
                <ul class="list">
                <li><a href="symptom.php">Các triệu chứng phổ biến</a></li>
                <li><a href="symptom-checker.php">Trình kiểm tra triệu chứng</a></li>
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
                <li><a href="about.php">Về COVID-19</a></li>
                <li><a href="doctors.php">Đội ngũ bác sĩ</a></li>
                <li><a href="sample-right-sidebar.php">Tin tức</a></li>
                <li><a href="search.php">Tìm kiếm</a></li>
                </ul>
            </li>
    
            <li>
                <a href="index.php">Tin tức
                <i class="linearicons-chevron-down"></i>
                </a>
                <ul class="list">
                <li><a href="blog.php">Tin tức</a></li>
                <li><a href="single-blog.php">Tin tức chi tiết</a></li>
    
                </ul>
            </li>
            <li><a href="contact.php">Liên hệ</a></li>
            </ul>
        </div>
        <div class="menu_btm">
            <a class="green_btn" href="#"><i class="linearicons-pulse"></i>Đăng Ký Test COVID</a>
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
                <input class="form-control" type="text" id="name" name="name" placeholder="" required />
                <label><i class="linearicons-user"></i>Họ và tên</label>
              </div>
            </div>
            <div class="col-lg-12">
              <div class="form-group">
                <input class="form-control" type="text" id="email" name="email" placeholder="" required />
                <label><i class="linearicons-envelope-open"></i>Email
                  </label>
              </div>
            </div>
            <div class="col-lg-12">
              <div class="form-group">
                <input class="form-control" type="text" id="number" name="number" placeholder="" required />
                <label><i class="linearicons-telephone"></i>số điện thoại
                  </label>
              </div>
            </div>
            <div class="col-lg-12">
              <div class="form-group">
                <textarea name="message" id="message" cols="30" rows="10" class="form-control" required></textarea>
                <label><i class="linearicons-document"></i>Nội dung  </label>
              </div>
            </div>
            <div class="col-lg-12">
              <div class="form-group checkbox_field">
                <div class="checkbox">
                  <input type="checkbox" value="None" id="squared2" name="check" />
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
                <a class="navbar-brand" href="index.php">
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

        <div class="pagepiling">
            <div class="pp-scrollable section active">
                <div class="scroll-wrap">
                    <div class="p-section-bg" style="background-image:url('./images/checker_map.png');">
                    </div>
                    <div class="scrollable-content">
                        <div class="container">
                            <div class="virus_checker_content">
                                <div class="main_title">
                                    <h1>
                                        <br>
                                        <br>
                                    </h1>
                                    <h2>Bạn có thể đăng kí <span> Test/Xét nghiệm COVID-19 </span> tại đây <i class="fas fa-edit"></i></h2>
                                </div>
                                <h4><i> Xét nghiệm chẩn đoán COVID-19 là cần thiết nếu xảy ra một trong các trường hợp sau:</i></h4>
                                <ul class="list-unstyled">
                                    <li><i class="fas fa-notes-medical"></i><span>Có triệu chứng: </span>
                                        Người có các triệu chứng COVID-19 , chẳng hạn như sốt, ho, mệt mỏi hoặc khó thở.</li>
                                    <li><i class="fab fa-buffer"></i><span>Không có triệu chứng:</span><br>
                                    <p>   <i class="fas fa-caret-down"></i> Người không có triệu chứng nhưng đã tiếp xúc gần với người có kết quả xét nghiệm dương tính với vi rút COVID-19 hoặc bị nghi ngờ có vi rút.</p></li>
                                    <li><i class="fas fa-caret-down"></i> 
                                        Người tham gia vào các hoạt động làm tăng nguy cơ mắc COVID-19 và không ở cách xa những người khác ít nhất 2 mét - ví dụ như đi du lịch, tụ tập đông người hoặc không gian trong nhà đông đúc.</li>
                                </ul>
                                <div class="checked_button_info">
                                    <h4><i class="fas fa-search-dollar"></i> Bạn có muốn xem giá các loại test covid? </h4>
                                    <div class="check_btn" data-toggle="modal" data-target="#ambulanceModal">
                                        <input type="radio" name="yes" id="no" value="no" />
                                        <label for="no">Không</label>
                                    </div>
                                    <div class="check_btn moveDown">
                                        <input type="radio" name="yes" id="yes" value="yes" />
                                        <label for="yes">Có</label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            

            <div class="pp-scrollable section">
                <div class="scroll-wrap">
                    <div class="p-section-bg" style="background-image:url('./images/checker_map.png');"></div>
                    <div class="scrollable-content">
                        <div class="container">
                            <div class="virus_checker_content">
                                <div class="main_title">
                                    <div class="row virus_symptom_inner">
                                    <h5><br></h5><br><br><br><br>
                                    <h2>Hiện nay, Trung tâm đang sử dụng 2 loại kit test nhanh COVID-19 do Việt Nam và Mỹ sản xuất. Cụ thể chi phí test nhanh kháng nguyên SARS-CoV-2 như sau:</h2>
                                </div>

                                <?php
                                include('config.php');		
                                $sql = "SELECT * FROM `tbl_loai_xet_nghiem` ORDER BY `tbl_loai_xet_nghiem`.`loai_id` DESC ";
                                $ketquatruyvan  =mysqli_query($ket_noi,$sql);
                                   
                                    while($row = mysqli_fetch_array($ketquatruyvan)){                    
                                ;?>
                                    
                                    <div class="col-md-12">
                                        <div class="media virus_symptom">
                                            <div class="round_img">
                                                <img  style="width: 135px; height: 100px;" class="img-fluid" src="<?php echo $row['anh_minh_hoa'] ? 'images/loai_xet_nghiem/'.$row['anh_minh_hoa'] :'images/loai_xet_nghiem/loai1.png';?>" alt="">
                                            </div>
                                            <div class="media-body">
                                                <h5><?php echo $row['ten_loai']; ?></h5>
                                                <p><?php echo $row['mo_ta']; ?></p>
                                                 <h5><i> Giá: <?php echo $row['gia']; ?> đ/mẫu</i></h5>
                                            </div>
                                            <div class="product-footer">
                                      <a href="form_dang_ky.php?loai_id=<?php echo $row['loai_id'] ?>" class="btn exit_btn">Đăng ký</a>
                                    </div>
                                        </div>
                                    </div>
                                <?php
                                    }

                                        mysqli_close($ket_noi);
                                    ;?>    
                                </div>
                                <div class="checked_button_info">
                                    <div class="check_btn" data-toggle="modal" data-target="#ambulanceModal">
                                        <input type="radio" name="yes" id="no2" value="no2" />
                                        <label for="no2">Thoát</label>
                                    </div>
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
                       
            </div>
        </div>
    </div>

    <!-- Modal -->
    <div class="modal fade ambulanceModal" id="ambulanceModal" role="dialog" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content text-center">
                <i class="linearicons-ambulance"></i>
                <h6>Bạn có chắc muốn thoát</h6>
                <h2></h2>
                <a href="index.php"  class="exit_btn"  >Exit</a>
            </div>
        </div>
    </div>

    <!-- Modal -->
    <div class="modal fade recommenddModal" id="recommenddModal" role="dialog" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="scroll_body">
                    <div class="main_title">
                       <h5>Hãy điền thông tin cá nhân và chọn loại test covid mà bạn muốn</h5>
                        <h2>ĐĂNG KÍ TEST/XÉT NGHIỆM COVID  <a href="form_dang_ky.php">TẠI ĐÂY</a>.</h2>
                    </div>
                    <p><span>Địa chỉ: 36 Ngô Quyền, phường Hàng Bài, quận Hoàn Kiếm, Hà Nội</span> </p>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade search_modal" id="exampleModal" tabindex="-1" role="dialog" aria-hidden="true">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
            <img src="images/icon/close-white.png" alt="">
        </button>
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-body">
                    <div class="input-group">
                        <input type="text" class="form-control" placeholder="Type here..."
                            aria-label="Recipient's username">
                        <div class="input-group-append">
                            <button class="btn btn-outline-secondary" type="button"><i
                                    class="linearicons-magnifier"></i></button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
<!-- đến đây nè -->
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="js/jquery-3.4.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="vendors/corona-live/dashboard.js"></script>
    <script src="vendors/isotop/imagesloaded.pkgd.min.js"></script>
    <script src="vendors/isotop/isotope.pkgd.min.js"></script>
    <script src="vendors/slick/slick.min.js"></script>
    <script src="vendors/mCustomScrollbar/jquery.mCustomScrollbar.concat.min.js"></script>
    <script src="js/theme.js"></script>
</body>

</html>