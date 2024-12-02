using System;
class Employee
{
    // Fields
    private int Id;
    public string Name;
    public string Address;

    // Constructor to initialize common employee data
    public Employee(int id, string name, string address)
    {
        this.Id = id;
        this.Name = name;
        this.Address = address;
    }

    // Method to display employee info
    public virtual void ShowInfo()
    {
        Console.WriteLine("ID:"+Id);
        Console.WriteLine("Name: "+Name);
        Console.WriteLine("Address: "+Address);
    }

    // Method to check bonus eligibility
    public virtual bool EmployeeStatus()
    {
        return false; // Base class has no specific bonus eligibility logic
    }
}

class Laborer : Employee
{
    // Additional fields for Laborer
    private double userRating; // 0-100%
    private const double chargePerService = 500.0; // Fixed charge per service
    private int noOfServices;

    // Constructor to initialize laborer data
    public Laborer(int id, string name, string address, double userRating, int noOfServices) : base(id, name, address)
    {
        this.userRating = userRating;
        this.noOfServices = noOfServices;
    }

    // Calculate total earnings
    public double TotalEarn()
    {
        return noOfServices * chargePerService;
    }

    // Check bonus eligibility
    public override bool EmployeeStatus()
    {
        return userRating > 70 && noOfServices >= 10;
    }

    // Override ShowInfo
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("User Rating: "+userRating);
        Console.WriteLine("Number of Services: "+noOfServices);
        Console.WriteLine("Total Earned: "+TotalEarn());
        Console.WriteLine("Eligible for Bonus:"+EmployeeStatus());
    }
}

class Manager : Employee
{
    // Additional field for Manager
    private int yearsOfExperience;

    // Constructor to initialize manager data
    public Manager(int id, string name, string address, int yearsOfExperience) : base(id, name, address)
    {
        this.yearsOfExperience = yearsOfExperience;
    }

    // Check bonus eligibility
    public override bool EmployeeStatus()
    {
        return yearsOfExperience > 2;
    }

    // Override ShowInfo
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Years of Experience: "+yearsOfExperience);
        Console.WriteLine("Eligible for Bonus: "+EmployeeStatus());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Laborer
        Laborer obj1 = new Laborer(1, "John Doe", "123 Street, City", 75.0, 9);
        Console.WriteLine("Laborer Info:");
        obj1.ShowInfo();
        Console.WriteLine();

        // Create a Manager
        Manager obj2 = new Manager(2, "Jane Smith", "456 Avenue, City", 1);
        Console.WriteLine("Manager Info:");
        obj2.ShowInfo();
    }
}