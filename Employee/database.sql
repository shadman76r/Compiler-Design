-- Step 1: Create the Database
CREATE DATABASE IF NOT EXISTS employee_management;

-- Step 2: Use the Database
USE employee_management;

-- Step 3: Create the Employees Table
CREATE TABLE IF NOT EXISTS employees (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,  -- ❌ No Hashing (Plain Text Passwords)
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Step 4: Insert a Sample Employee (No Hashed Password)
INSERT INTO employees (name, email, password) 
VALUES ('John Doe', 'john@example.com', '123456');  -- ❌ Plain Text Password
