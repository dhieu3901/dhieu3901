        <?php
        //viết các câu lệnh thêm mới tin tức ở đây
        include('config.php');

        //lấy ra được các dữ liệu mà trang TIN TỨC THÊM MỚI chuyển sang

        $ten_loai = $_POST["txtTenLoai"];
        $mo_ta = $_POST["txtMoTa"];
        $gia= $_POST["txtGia"];

        //Xử lý hình ảnh --> chưa được
        $anh_minh_hoa = "../images/".basename($_FILES["txtAnhMinhHoa"]["name"]);
        $file_anh_tam=$_FILES["txtAnhMinhHoa"]["tmp_name"];

        //UPLOAD lên máy chủ web
        $result = move_uploaded_file($file_anh_tam, $anh_minh_hoa);
        if (!$result) {
            $anh_minh_hoa=NULL;
        } else {
            $anh_minh_hoa=basename($_FILES["txtAnhMinhHoa"]["name"]);
        }

        //VIết câu lệnh truy vấn để thêm mới dữ liệu vào bảng TIN TỨC trong CSDL
        $sql= "INSERT INTO tbl_loai_xet_nghiem (ten_loai, anh_minh_hoa, mo_ta, gia) 
        VALUES ( '".$ten_loai."','".$anh_minh_hoa."',  '".$mo_ta."', '".$gia."');";
        $noi_dung_tin_tuc=mysqli_query($ket_noi,$sql);
      
        // hiển thị ra thông báo bạn đã thêm mới tin tức thành công và đẩy các bạn về trang quản trị tin tức
         echo "
                <script type='text/javascript'>
                    window.alert('Bạn đã thêm  thành công');
                </script>
            ";
                   echo "
                <script type='text/javascript'>
                    window.location.href='loai_xet_nghiem.php';
                </script>
            ";
        ;?>
