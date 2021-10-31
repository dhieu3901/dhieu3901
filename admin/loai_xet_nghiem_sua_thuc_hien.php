    </body>
</html>

        <?php
        //viết các câu lệnh thêm mới tin tức ở đây

        include('config.php');

        //lấy ra được các dữ liệu mà trang TIN TỨC THÊM MỚI chuyển sang
        $loai_id=$_POST["txtID"];
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
        // 3. Viết câu lệnh truy vấn để sửa dữ liệu vào bảng TIN TỨC trong CSDL)
            if($anh_minh_hoa == NULL) {                         
                $sql = "
                        UPDATE tbl_loai_Xet_nghiem 
                        SET ten_loai = '".$ten_loai."',mo_ta = '".$mo_ta."', `gia` = '".$gia."'
                        WHERE `loai_id` = '".$loai_id."'
                        ";
            } else {           
                $sql = "
                    UPDATE tbl_loai_Xet_nghiem 
                        SET anh_minh_hoa='".$anh_minh_hoa."' ten_loai = '".$ten_loai."',mo_ta = '".$mo_ta."', `gia` = '".$gia."'
                        WHERE `loai_id` = '".$loai_id."'
                        
                    ";                
            }
        //echo $sql; exit();
        $noi_dung_=mysqli_query($ket_noi,$sql);

        // while ($row = mysql_fetch_array($noi_dung_tin_tuc)) {
        // 	# code...
        // }
        // hiển thị ra thông báo bạn đã thêm mới tin tức thành công và đẩy các bạn về trang quản trị tin tức
        echo "
                <script type='text/javascript'>
                    window.alert('Bạn đã sửa thành công');
                </script>
            ";

            echo "
                <script type='text/javascript'>
                    window.location.href='loai_xet_nghiem.php';
                </script>
            ";
        ;?>
