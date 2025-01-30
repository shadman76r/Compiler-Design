<?php
require_once 'Database.php';

class EmployeeModel {
    private $conn;

    public function __construct() {
        $database = new Database();
        $this->conn = $database->connect();
    }

    public function checkEmployeeLogin($email, $password) {
        $query = "SELECT * FROM employees WHERE email = ? AND password = ?"; // ✅ No hashing
        $stmt = $this->conn->prepare($query);
        $stmt->bind_param("ss", $email, $password);
        $stmt->execute();
        $result = $stmt->get_result();

        if ($result->num_rows == 1) {
            return $result->fetch_assoc(); // ✅ Return employee data if login is successful
        }
        return false;
    }
}
?>
