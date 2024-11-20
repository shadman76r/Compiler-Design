using System;

namespace InheritanceExample
{
    // Base class
    public class Person
    {
        // Private/Protected Fields
        private string name;
        private string dob;

        // Constructors
        public Person() { }

        public Person(string name, string dob)
        {
            this.name = name;
            this.dob = dob;
        }

        // Methods
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetDob(string dob)
        {
            this.dob = dob;
        }

        public string GetDob()
        {
            return dob;
        }
    }

    // Employee Class
    public class Employee : Person
    {
        // Private Field
        private Account acc;

        // Constructors
        public Employee() { }

        public Employee(string name, string dob, Account acc)
            : base(name, dob)
        {
            this.acc = acc;
        }

        public Employee(int accountId, double amount, string accType)
        {
            this.acc = new Account(accountId, amount, accType);
        }

        // Methods
        public void SetAcc(Account acc)
        {
            this.acc = acc;
        }

        public void Display()
        {
            Console.WriteLine($"Employee Name: {GetName()}, DOB: {GetDob()}");
            acc?.DisplayAccountDetails();
        }
    }

    // Customer Class
    public class Customer : Person
    {
        // Private Field
        private Account acc;

        // Constructors
        public Customer() { }

        public Customer(string name, string dob, Account acc)
            : base(name, dob)
        {
            this.acc = acc;
        }

        public void SetAcc(Account acc)
        {
            this.acc = acc;
        }

        public void Display()
        {
            Console.WriteLine($"Customer Name: {GetName()}, DOB: {GetDob()}");
            acc?.DisplayAccountDetails();
        }
    }

    // Account Class
    public class Account
    {
        // Fields
        private int accountId;
        private double amount;
        private string accType;

        // Constructor
        public Account(int accountId, double amount, string accType)
        {
            this.accountId = accountId;
            this.amount = amount;
            this.accType = accType;
        }

        // Methods
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account ID: {accountId}, Amount: {amount}, Type: {accType}");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Account
            Account empAccount = new Account(1001, 5000.75, "Savings");
            Account custAccount = new Account(2001, 3000.50, "Current");

            // Creating Employee and Customer
            Employee emp = new Employee("John Doe", "1990-01-01", empAccount);
            Customer cust = new Customer("Jane Smith", "1995-05-15", custAccount);

            // Displaying Details
            emp.Display();
            cust.Display();
        }
    }
}
