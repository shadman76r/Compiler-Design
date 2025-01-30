<?php
session_start();
require_once '../models/EmployeeModel.php';

class EmployeeController {
    private $employeeModel;

    public function __construct() {
        $this->employeeModel = new EmployeeModel();
    }

    public function login() {
        if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST['submit'])) {
            $email = $_POST['email'];
            $password = $_POST['password'];

            // Debugging Output
            echo "Email Entered: " . $email . "<br>";
            echo "Password Entered: " . $password . "<br>";

            $employee = $this->employeeModel->checkEmployeeLogin($email, $password);

            if ($employee) {
                $_SESSION['employee_id'] = $employee['id'];
                $_SESSION['employee_name'] = $employee['name'];
                $_SESSION['employee_email'] = $employee['email'];

                header("Location: ../views/dashboard.php");
                exit();
            } else {
                echo "<p style='color: red;'>Invalid credentials. Debugging mode ON.</p>";
            }
        }
    }
}

// Handling Login Request
if (isset($_POST['submit'])) {
    $controller = new EmployeeController();
    $controller->login();
}
?>
