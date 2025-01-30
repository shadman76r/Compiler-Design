<?php
session_start();
session_destroy();
header("Location: views/employee_login.php");
exit();
?>
