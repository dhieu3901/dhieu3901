
        <?php
        //viết các câu lệnh thêm mới tin tức ở đây

        include('config.php');

        //lấy ra được các dữ liệu mà trang TIN TỨC THÊM MỚI chuyển sang
        $tin_tuc_id=$_POST["txtID"];
        $tieu_de = $_POST["txtTieuDe"];
        $hashtag_id=$_POST["txtHashtag"];
        $mo_ta = $_POST["txtMoTa"];
        $noi_dung = $_POST["txtNoiDung"];
        $tac_gia= $_POST["txtTacGia"];
        
        $ngay_dang_tin= $_POST["txtNgayDangTin"];
        $so_lan_doc= $_POST["txtSoLanDoc"];
        $ghi_chu= $_POST["txtGhiChu"];

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
                        UPDATE tbl_tin_tuc 
                        SET tieu_de = '".$tieu_de."',hashtag_id='".$hashtag_id."',mo_ta = '".$mo_ta."', `noi_dung` = '".$noi_dung."',tac_gia='".$tac_gia."',ngay_dang_tin='".$ngay_dang_tin."',so_lan_doc='".$so_lan_doc."',ghi_chu='".$ghi_chu."'
                        WHERE `tin_tuc_id` = '".$tin_tuc_id."'
                        ";
            } else {           
                $sql = "
                    UPDATE `tbl_tin_tuc` 
                    SET `tieu_de` = '".$tieu_de."',anh_minh_hoa = '".$anh_minh_hoa."',hashtag_id='".$hashtag_id."', `mo_ta` = '".$mo_ta."', `noi_dung` = '".$noi_dung."', tac_gia='".$tac_gia."',ngay_dang_tin='".$ngay_dang_tin."',so_lan_doc='".$so_lan_doc."',ghi_chu='".$ghi_chu."'
                    WHERE `tin_tuc_id` = '".$tin_tuc_id."'
                    ";                
            }
        //echo $sql; exit();
        $noi_dung_tin_tuc=mysqli_query($ket_noi,$sql);

        // while ($row = mysql_fetch_array($noi_dung_tin_tuc)) {
        // 	# code...
        // }
        // hiển thị ra thông báo bạn đã thêm mới tin tức thành công và đẩy các bạn về trang quản trị tin tức
        echo "
                <script type='text/javascript'>
                    window.alert('Bạn đã sửa bài viết thành công');
                </script>
            ";

            echo "
                <script type='text/javascript'>
                    window.location.href='quan_tri_tin_tuc.php';
                </script>
            ";
        ;?>
