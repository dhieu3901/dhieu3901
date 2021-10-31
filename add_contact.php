<?php 
	// 1. Đọc dữ liệu từ trang ĐĂNG NHẬP gửi sang
	$name = $_POST["txtName"];
	$email = $_POST["txtEmail"];
	$phone = $_POST["txtPhone"];
	$message = $_POST["txtMessage"];

	// 2. KẾT NỐI ĐẾN CSDL
	include('config.php');

	// 3. So sánh dữ liệu nhập vào có khớp với dữ liệu lưu trong CSDL hay không?
	$sql = "
		INSERT INTO tbl_lien_he (name,email,phone,message)
		VALUES ('".$name."','".$email."','".$phone."','".$message."')
	";
	// 3. Thực thi câu lệnh để xác định dữ liệu có khớp hay không?
	$thuc_hien_phan_hoi = mysqli_query($ket_noi, $sql);
	if($name != "" AND $message != ""){
    echo 
		"
			<script type='text/javascript'>
				window.alert('Cảm ơn bạn đã gửi phản hồi cho chúng tôi.');
			</script>
		";
		echo 
		"
			<script type='text/javascript'>
				window.location.href='index.php'
			</script>
		";
}
 else {
    echo 
		"
			<script type='text/javascript'>
				window.alert('Bạn hãy nhập đủ thông tin');
			</script>
		";
		echo 
		"
			<script type='text/javascript'>
				window.location.href='contact.php'
			</script>
		";
	}
	
?>