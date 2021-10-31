<?php 
	// 1. Đọc dữ liệu từ trang ĐĂNG NHẬP gửi sang
	$ten = $_POST["txtHoTen"];
	$loai_id= $_POST["loai_id"];
	$ngay_xet_nghiem=$_POST["txtNgayXN"];
	$quan = $_POST["txtQuanHuyen"];
	$phuong = $_POST["txtPhuongXa"];
	$duong = $_POST["txtDuong"];
	$dia_diem_lay_mau = $_POST["txtDiaChi"];
	$sdt = $_POST["txtDienThoai"];
	$email = $_POST["txtEmail"];
	$hinh_thuc_thanh_toan = $_POST["txtThanhToan"];
	$so_tien=$_POST['gia'];
	$NhanKQ =$_POST['txtnhankq'];
	$dia_chi =$duong. " " .$phuong. " " .$quan;
	$today = date("Y/m/d");
	// 2. KẾT NỐI ĐẾN CSDL
	include('config.php');		

	// 3. So sánh dữ liệu nhập vào có khớp với dữ liệu lưu trong CSDL hay không?
	$sql = " INSERT INTO `tbl_xet_nghiem` (`xet_nghiem_id`, `ten`, `email`, `sdt`, `loai_id`, `ngay_xet_nghiem`, `so_tien`, ngay_thanh_toan,`dia_chi`, `dia_diem_lay_mau`, `hinh_thuc_thanh_toan`,`nhan_kq`) 
			VALUES (NULL, '".$ten."', '".$email."', '".$sdt."', '".$loai_id."', '".$ngay_xet_nghiem."', '".$so_tien."','".$today."','".$dia_chi."', '".$dia_diem_lay_mau."', '".$hinh_thuc_thanh_toan."','".$NhanKQ."')
	";
	// 3. Thực thi câu lệnh để xác định dữ liệu có khớp hay không?
	$thuc_hien_phan_hoi = mysqli_query($ket_noi, $sql);

	// 4. Điều hướng người dùng về trang họ được phép truy cập

	if ($hinh_thuc_thanh_toan = 'cod') {
		if ($ten != "" AND $quan != "" AND $phuong != "" AND $duong != "" AND $email != "" AND $sdt != ""  ) {
			# Đẩy người dùng về trang đăng nhập
			echo 
			"
				<script type='text/javascript'>
					window.alert('Đặt đăng ký thành công.');
				</script>
			";
			echo 
			"
				<script type='text/javascript'>
					window.location.href='index.php'
				</script>
			";
		}
	}else{

		if ($ten != "" AND $quan != "" AND $phuong != "" AND $duong != "" AND $email != "" AND $sdt != ""  ) {
			# Đẩy người dùng về trang đăng nhập
			echo 
			"
				<script type='text/javascript'>
					window.alert('Đặt đăng ký thành công.');
				</script>
			";
			echo 
			"
				<script type='text/javascript'>
					window.location.href='index.php'
				</script>
			";
		}
	}
 
?>