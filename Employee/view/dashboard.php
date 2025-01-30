<?php
session_start();
if (!isset($_SESSION['employee_id'])) {
    header("Location: employee_login.php");
    exit();
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Employee Dashboard</title>
</head>
<body>

<h1>Welcome, <?php echo $_SESSION['employee_name']; ?>!</h1>
<p>Your Email: <?php echo $_SESSION['employee_email']; ?></p>

<a href="../logout.php">Logout</a>

</body>
</html>
