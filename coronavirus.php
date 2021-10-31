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
  <link rel="stylesheet" href="vendors/slick/slick.css" />
  <link rel="stylesheet" href="vendors/slick/slick-theme.css" />
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
                <li class="dropdown submenu active">
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
    <section class="breadcrumb_area">
      <div class="container">
        <div class="breadcrumb_text">
          <h6 class="wow fadeInUp" data-wow-delay="0.2s">Đại dịch COVID-19</h6>
          <h3 class="wow fadeInUp" data-wow-delay="0.2s">Coronavirus</h3>
          <form action="#" class="faq_search" > 
            <div class="control-with-icon">
              <input type="text" class="form-control" placeholder="Từ khóa..." required="" />
              <span class="control-icon"><i class="linearicons-funnel"></i></span>
            </div>
          </form>
          <ul class="nav justify-content-center wow fadeInUp" data-wow-delay="0.3s">
            <li><a href="index.php">Trang chủ</a></li>
            <li><a href="about.php">Giới thiệu</a></li>
            <li><a href="#">Thông tin về COVID-19</a></li>
          </ul>
        </div>
      </div>
    </section>
    <!--================End Breadcrumb Area =================-->
    <!--================ About Area =================-->
    <section class="home_about_corona about_corona_aera">
      <div class="container">
        <div class="row">
          <div class="col-lg-6">
            <div class="home_ab_img">
              <img class="wow fadeInUp" data-wow-delay="500ms" src="images/about/virus.jpg" style="width:550px;height:auto;"alt="" />
            </div>
          </div>
          <div class="col-lg-6">
            <div class="home_ab_text">
              <div class="home_ab_text_inner">
                <div class="home_ab_item">
                  <h4 class="wow fadeInUp">Đại dịch Coronavirus 2019-2021</h4>
                  <p class="wow fadeInUp" data-wow-delay="0.2s">
                    là một đại dịch đang diễn ra của bệnh coronavirus 2019 (COVID-19), do coronavirus 2 (SARS-CoV-2) gây ra hội chứng hô hấp cấp tính nghiêm trọng. Đợt bùng phát lần đầu tiên được xác định tại Vũ Hán, Hồ Bắc, Trung Quốc, vào tháng 12 năm 2019. Tổ chức Y tế Thế giới (WHO) tuyên bố đợt bùng phát là tình trạng khẩn cấp về sức khỏe cộng đồng cần quan tâm của quốc tế vào ngày 30 tháng 1 năm 2020 và công nhận là đại dịch vào ngày 11 tháng 3 năm 2020
                  </p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
    <!--================End About Area =================-->
    <div class="container">     
        <div class="coronavirus_promo_content">   
          <h2> Coronavirus là gì?</h2>
          <p>
            Coronavirus là một loại vi rút. Có nhiều loại khác nhau, và một số gây bệnh. Một loại coronavirus được xác định vào năm 2019, SARS-CoV-2, đã gây ra đại dịch bệnh đường hô hấp, được gọi là COVID-19.
            <ol>
              <li>COVID-19 là bệnh do SARS-CoV-2, loại coronavirus xuất hiện vào tháng 12 năm 2019.</li>
              <li>COVID-19 có thể nghiêm trọng và đã gây ra cái chết cho hàng triệu người trên khắp thế giới cũng như các vấn đề sức khỏe kéo dài ở một số người đã sống sót sau cơn bạo bệnh.</li>
              <li>Coronavirus có thể lây từ người này sang người khác. Nó được chẩn đoán bằng xét nghiệm trong phòng thí nghiệm.</li>
              <li>Vắc xin COVID-19 đã được Cục Quản lý Thực phẩm và Dược phẩm Hoa Kỳ cho phép sử dụng khẩn cấp, và các chương trình tiêm chủng đang được tiến hành trên khắp Hoa Kỳ và nhiều nơi trên thế giới.</li>
          </ol>
          </p>
          <h5>Coronavirus lây lan như thế nào?</h5>
          <p>Cho đến nay, các nhà nghiên cứu biết rằng coronavirus lây lan qua các giọt nhỏ và các phần tử virus được phát tán vào không khí khi một người bị nhiễm bệnh hít thở, nói chuyện, cười, hát, ho hoặc hắt hơi. Những giọt lớn hơn có thể rơi xuống đất trong vài giây, nhưng những hạt truyền nhiễm nhỏ có thể tồn tại trong không khí và tích tụ ở những nơi trong nhà, đặc biệt là nơi tập trung nhiều người và có hệ thống thông gió kém. Đây là lý do tại sao việc đeo khẩu trang, vệ sinh tay và cách xa cơ thể là điều cần thiết để ngăn ngừa COVID-19.</p>
          <h5>Coronavirus bắt đầu như thế nào?</h5>
          <p>Trường hợp đầu tiên của COVID-19 đã được báo cáo vào ngày 1 tháng 12 năm 2019 và nguyên nhân là do một loại coronavirus sau đó mới được đặt tên là SARS-CoV-2. SARS-CoV-2 có thể có nguồn gốc từ động vật và bị biến đổi (đột biến) nên có thể gây bệnh cho người. Trong quá khứ, một số vụ bùng phát bệnh truyền nhiễm đã được bắt nguồn từ vi rút có nguồn gốc từ chim, lợn, dơi và các động vật khác bị đột biến để trở nên nguy hiểm đối với con người. Nghiên cứu vẫn tiếp tục, và nhiều nghiên cứu hơn có thể tiết lộ cách thức và lý do tại sao coronavirus phát triển để gây ra đại dịch.</p>
          <h5>Thời gian ủ bệnh cho COVID-19 là gì?</h5>
          <p>Các triệu chứng xuất hiện ở những người trong vòng hai đến 14 ngày kể từ ngày tiếp xúc với vi rút. Một người bị nhiễm coronavirus có thể lây cho người khác trong tối đa hai ngày trước khi các triệu chứng xuất hiện và họ vẫn lây cho người khác trong 10 đến 20 ngày, tùy thuộc vào hệ thống miễn dịch của họ và mức độ bệnh của họ. </p>       
          </div>
      </div>
    <!--================start About content Area =================-->
    <section class="about_cronacvirus_promo_area">
      <ul class="list-unstyled shap_img">
        <li><img src="images/about/promo_bg_shap3.png" alt=""></li>
        <li><img src="images/about/promo_bg_shap2.png" alt=""></li>
        <li><img src="images/about/promo_bg_shap1.png" alt=""></li>
      </ul>
      <div class="container">
        <div class="row">
          <div class="col-lg-6">
            <div class="coronavirus_promo_content">  
            <h2>Các triệu chứng của coronavirus là gì?</h2>          
              <h5>Các triệu chứng COVID-19 bao gồm:</h5>
              <ol>
                  <ul>Ho </ul>
                  <ul>Sốt hoặc ớn lạnh</ul>
                  <ul>Thở gấp hoặc khó thở</ul>
                  <ul>Đau nhức cơ hoặc cơ thể</ul>
                  <ul>Viêm họng</ul>
                  <ul>Mất vị giác hoặc mùi mới</ul>
                  <ul>Bệnh tiêu chảy</ul>
                  <ul>Đau đầu</ul>
                  <ul>Mệt mỏi mới</ul>
                  <ul>Buồn nôn hoặc nôn mửa</ul>
                  <ul>Nghẹt mũi hoặc chảy nước mũi</ul>
              </ol>
              <p>Một số người bị nhiễm coronavirus bị bệnh COVID-19 nhẹ, và những người khác không có triệu chứng gì. Tuy nhiên, trong một số trường hợp, COVID-19 có thể dẫn đến suy hô hấp, tổn thương phổi và cơ tim kéo dài , các vấn đề về hệ thần kinh , suy thận hoặc tử vong.</p>
              <p>Nếu bạn bị sốt hoặc bất kỳ triệu chứng nào được liệt kê ở trên, hãy gọi cho bác sĩ hoặc nhà cung cấp dịch vụ chăm sóc sức khỏe và giải thích các triệu chứng của bạn qua điện thoại trước khi đến văn phòng bác sĩ, cơ sở chăm sóc khẩn cấp hoặc phòng cấp cứu.</p>
              <h3>GỌI 911 nếu bạn gặp trường hợp khẩn cấp về y tế như khó thở hoặc khó thở nghiêm trọng.</h3>

            </div>
          </div>
        </div>
      </div>
      <div class="bg_img">
        <img class="shap" src="images/about/about_promo_bg.png" alt="">
        <ul class="list-unstyled shap_img_two">
          <li><img src="images/about/promo_bg_shap8.png" alt=""></li>
          <li><img src="images/about/promo_bg_shap7.png" alt=""></li>
          <li><img src="images/about/promo_bg_shap6.png" alt=""></li>
          <li data-parallax='{"y": 50}'><img src="images/about/promo_bg_shap5.png" alt=""></li>
          <li data-parallax='{"x": 50}'><img src="images/about/promo_bg_shap4.png" alt=""></li>
        </ul>
      </div>
    </section>
    <!--================End About content Area =================-->
    <!--================Start Faqs Area =================-->
    <section class="about_faq_area">
      <div class="container">
        <div class="main_title text-center">
          <h5 class="wow fadeInUp">Bạn có câu hỏi? </h5>
          <h2 class="wow fadeInUp" data-wow-delay="0.2s">Các câu hỏi thường gặp (FAQS)</h2>
        </div>
        <div class="row">
          <div class="col-lg-6">
            <div class="faq_img">
              <img src="images/about/dauhoi.jpg" alt="" />
            </div>

          </div>
          <div class="col-lg-6">
            <div class="question_list faq_inner">
              <div class="accordion" id="accordionExample">
                <div class="card wow fadeInUp">
                  <div class="card-header" id="headingOne">
                    <button class="btn btn-link" type="button" data-toggle="collapse" data-target="#collapseOne"
                      aria-expanded="true" aria-controls="collapseOne">
                      Coronavirus là gì?
                      <i class="linearicons-chevron-down"></i>
                    </button>
                  </div>

                  <div id="collapseOne" class="collapse show" aria-labelledby="headingOne"
                    data-parent="#accordionExample">
                    <div class="card-body">
                      <div class="faq_content">
                        <p>
                          COVID-19 là một bệnh truyền nhiễm đường hô hấp do nhiễm virus SARS-CoV-2. Bệnh thường lây lan giữa những người tiếp xúc gần (trong vòng 2 mét). Virus lây lan qua các giọt bắn khi một người thở, ho, hắt hơi, nói chuyện hoặc hát. Những giọt bắn này có thể rơi vào miệng hoặc mũi của ai đó gần đó hoặc được hít vào. Virus cũng có thể lây lan nếu một người chạm vào bề mặt hoặc vật thể có virus và sau đó chạm vào miệng, mũi hoặc mắt của họ, mặc dù đây không được coi là đường lây lan chính.Các triệu chứng phổ biến nhất của COVID-19 là sốt, ho và mệt mỏi. Nhưng có nhiều dấu hiệu và triệu chứng khác cũng có thể xảy ra.Hiện tại, chỉ có một loại thuốc kháng virus, được gọi là remdesivir, được chấp thuận để điều trị COVID-19. Một số loại thuốc có thể giúp giảm mức độ nghiêm trọng của COVID-19. Cơ quan Quản lý Thực phẩm và Dược phẩm Hoa Kỳ đã cấp phép sử dụng khẩn cấp hai loại vaccine ngừa COVID-19.
                        </p>
                        
                      </div>
                    </div>
                  </div>
                </div>
                <div class="card wow fadeInUp" data-wow-delay="0.3s">
                  <div class="card-header" id="headingThree">
                    <button class="btn btn-link collapsed" type="button" data-toggle="collapse"
                      data-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                     Sự khác biệt giữa COVID-19 và cảm lạnh thông thường là gì?
                      <i class="linearicons-chevron-down"></i>
                    </button>
                  </div>
                  <div id="collapseThree" class="collapse" aria-labelledby="headingThree"
                    data-parent="#accordionExample">
                    <div class="card-body">
                      <div class="faq_content">
                        <p>
                          Cả COVID-19 và cảm lạnh thông thường đều do virus gây ra. COVID-19 do SARS-CoV-2 gây ra, trong khi cảm lạnh thông thường thường do rhinovirus gây ra. Những virus này lây lan theo những cách tương tự nhau và gây ra nhiều dấu hiệu và triệu chứng giống nhau. Tuy nhiên, có một vài điểm khác biệt.Trong khi các triệu chứng COVID-19 thường xuất hiện từ 2 đến 14 ngày sau khi tiếp xúc với SARS-CoV-2, các triệu chứng của cảm lạnh thông thường thường xuất hiện từ 1 đến 3 ngày sau khi tiếp xúc với virus gây cảm lạnh.Không có thuốc chữa cảm lạnh thông thường. Điều trị có thể bao gồm thuốc giảm đau và thuốc trị cảm lạnh không kê đơn, chẳng hạn như thuốc thông mũi. Không giống như COVID-19, cảm lạnh thường vô hại. Hầu hết mọi người đều hồi phục sau cảm lạnh thông thường trong vòng 3 đến 10 ngày.
                        </p>
                       
                      </div>
                    </div>
                  </div>
                </div>
                <div class="card wow fadeInUp" data-wow-delay="0.4s">
                  <div class="card-header" id="headingfour">
                    <button class="btn btn-link collapsed" type="button" data-toggle="collapse"
                      data-target="#collapsefour" aria-expanded="false" aria-controls="collapsefour">
                      Sự khác biệt giữa COVID-19 và bệnh cúm là gì?
                      <i class="linearicons-chevron-down"></i>
                    </button>
                  </div>
                  <div id="collapsefour" class="collapse" aria-labelledby="headingfour" data-parent="#accordionExample">
                    <div class="card-body">
                      <div class="faq_content">
                        <p>
                          COVID-19 và bệnh cúm đều là những bệnh truyền nhiễm đường hô hấp do virus gây ra. COVID-19 do virus SARS-CoV-2 gây ra, trong khi bệnh cúm do virus cúm A và B. Những virus này lây lan theo những cách tương tự.COVID-19 và bệnh cúm gây ra các triệu chứng tương tự. Các bệnh này cũng có thể không gây ra triệu chứng hoặc các triệu chứng nhẹ hoặc nghiêm trọng. Vì có nhiều điểm tương đồng, khó có thể chẩn đoán bạn mắc bệnh nào nếu chỉ dựa vào các triệu chứng. Xét nghiệm có thể được thực hiện để xem liệu bạn có bị nhiễm COVID-19 hay bệnh cúm hay không. Bạn cũng có thể mắc cả hai bệnh cùng một lúc. Tuy nhiên, chúng vẫn có một số khác biệt.Các triệu chứng COVID-19 thường xuất hiện từ 2 đến 14 ngày sau khi tiếp xúc với SARS-CoV-2. Các triệu chứng cúm thường xuất hiện khoảng 1 đến 4 ngày sau khi tiếp xúc với virus cúm.COVID-19 có thể gây ra các bệnh nghiêm trọng hơn ở một số người so với bệnh cúm. Ngoài ra, COVID-19 có thể gây ra các biến chứng khác với bệnh cúm, chẳng hạn như cục máu đông và hội chứng viêm đa hệ ở trẻ em.Mặc dù chỉ có một phương pháp điều trị kháng virus COVID-19, nhưng có một số loại thuốc kháng virus có thể được sử dụng để điều trị bệnh cúm. Ngoài ra, bạn có thể tiêm phòng cúm hàng năm để giúp giảm nguy cơ mắc bệnh cúm. Thuốc chủng ngừa cúm cũng có thể làm giảm mức độ nghiêm trọng của bệnh cúm và nguy cơ biến chứng nghiêm trọng. Vaccine có thể được tiêm dưới dạng tiêm hoặc xịt mũi.
                        </p>
                        
                      </div>
                    </div>
                  </div>
                </div>
                <div class="card wow fadeInUp" data-wow-delay="0.5s">
                  <div class="card-header" id="headingfive">
                    <button class="btn btn-link collapsed" type="button" data-toggle="collapse"
                      data-target="#collapsefive" aria-expanded="false" aria-controls="collapsefive">
                      Làm thế nào bạn có thể tránh bị COVID-19, cảm lạnh và cúm?
                      <i class="linearicons-chevron-down"></i>
                    </button>
                  </div>
                  <div id="collapsefive" class="collapse" aria-labelledby="headingfive" data-parent="#accordionExample">
                    <div class="card-body">
                      <div class="faq_content">
                        <p>
                          Bạn có thể giảm nguy cơ nhiễm virus gây ra COVID-19, cảm lạnh và cúm bằng cách tuân theo một số biện pháp phòng ngừa tiêu chuẩn. Nghiên cứu cho thấy rằng thực hiện theo các biện pháp này, chẳng hạn như giãn cách xã hội và đeo khẩu trang, có thể giúp rút ngắn thời gian của mùa cúm và giảm bớt số người bị ảnh hưởng trong mùa cúm 2019-2020.Các biện pháp phòng ngừa tiêu chuẩn để giảm nguy cơ mắc COVID-19, cảm lạnh và cúm bao gồm:</p>
                      
                          <ul>- Tránh tiếp xúc gần (trong vòng 2 mét) với bất kỳ ai bên ngoài hộ gia đình của bạn</ul>
                          <ul>- Đeo khẩu trang bằng vải khi ở nơi công cộng, chẳng hạn như cửa hàng tạp hóa, nơi bạn khó tránh tiếp xúc gần với người khác</ul>
                          <ul>- Thường xuyên rửa tay bằng xà phòng và nước trong ít nhất 20 giây hoặc sử dụng chất khử trùng tay có cồn có chứa ít nhất 60% cồn</ul>
                          <ul>- Tránh không gian đông đúc trong nhà</ul>
                          <ul>- Che miệng và mũi bằng khuỷu tay hoặc khăn giấy khi ho hoặc hắt hơi</ul>
                          <ul>- Tránh chạm vào mắt, mũi và miệng của bạn</ul>
                          <ul>- Làm sạch và khử trùng các bề mặt dễ tiếp xúc, chẳng hạn như tay nắm cửa, công tắc đèn, thiết bị điện tử và quầy hàng ngày</ul>                      
                        
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
    <!--================End Faq Area =================-->
    <!--================Start about service Area =================-->
    <section class="about_features_area">
      <div class="container">
        <div class="row justify-content-center">
          <div class="col-lg-4 col-md-6 wow fadeIn" data-wow-delay="400ms">
            <div class="about_features_item">
              <div class="round_icon">
                <img src="images/about/about_features_img1.png" alt="" />
              </div>
              <h5>Diễn biến dịch bệnh</h5>
              <h3>Chuyện vượt "cửa tử" của những F0</h3>
              <p>
                Có những gia đình cả nhà là F0 hay những sản phụ mang thai "vượt mặt" mắc Covid-19 đã kiên cường vượt "cửa tử" nhờ có sự đồng hành của các y bác sĩ.
              </p>
              
            </div>
          </div>
          <div class="col-lg-4 col-md-6 wow fadeIn" data-wow-delay="500ms">
            <div class="about_features_item">
              <div class="round_icon">
                <img src="images/about/about_features_img2.png" alt="" />
              </div>
              <h5>Chiến dịch tiêm chủng</h5>
              <h3>"Chìa khóa" để chấm dứt Covid-19</h3>
              <p>Các chuyên gia cho rằng, đảm bảo chuỗi cung vắc xin an toàn và không bị gián đoạn là chìa khóa quan trọng để chấm dứt đại dịch Covid-19.</p>
              
            </div>
          </div>
          <div class="col-lg-4 col-md-6 wow fadeIn" data-wow-delay="600ms">
            <div class="about_features_item">
              <div class="round_icon">
                <img src="images/about/about_features_img1.png" alt="" />
              </div>
              <h5>Thuốc điều trị</h5>
              <h3>PC-Covid được tạo ra như thế nào?</h3>
              <p>PC-Covid là ứng dụng được phát triển phục vụ cho công tác phòng, chống dịch Covid-19 của Việt Nam, để người dân sớm có được cuộc sống "bình thường mới".
              </p>
              
            </div>
          </div>
        </div>
      </div>
    </section>
    <!--================End about service Area =================-->
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