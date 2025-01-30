<?php
session_start();
if (isset($_SESSION['employee_id'])) {
    header("Location: dashboard.php");
    exit();
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Employee Login</title>
</head>
<body>

<h1>Employee Login</h1>

<?php if (isset($_GET['error'])) { ?>
    <p style="color: red;"><?php echo $_GET['error']; ?></p>
<?php } ?>

<form method="POST" action="../controllers/EmployeeController.php">
    <fieldset>
        <legend>Login</legend>
        <table>
            <tr>
                <td>Email Address:</td>
                <td><input type="email" name="email" required></td>
            </tr>
            <tr>
                <td>Password:</td>
                <td><input type="password" name="password" required></td>
            </tr>
        </table>
        <input type="submit" name="submit" value="Login">
        <input type="reset" value="Clear">
    </fieldset>
</form>

</body>
</html>
