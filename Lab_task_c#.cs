using System;

namespace VehicleApp
{
    //This is for base class
     public class Vehicle
    {
        // Member fields
        private string vehicleName;
        private string vehicleId;
        public static int vehicleCount;

        // This side is to access the private fields
        public string VehicleName
        {
            get 
            { 
                return vehicleName; 
            }
            set 
            { 
                vehicleName = value; 
            }
        }

        public string VehicleId
        {
            get 
            { 
                return vehicleId;
            }
            set 
            {
                vehicleId = value; 
            }
        }

        // Constractor 
        public Vehicle()
        {
            vehicleCount++;
        }

        // this code is for member methord
        public virtual void Status()
        {
            Console.WriteLine("Vehicle status: Active");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Vehicle Name: {VehicleName}, Vehicle ID: {VehicleId}");
        }
    }

    // Derived classes
    class Motorbike : Vehicle
    {
        public Motorbike()
        {
            VehicleName = "Motorbike";
            VehicleId = "MB001";
        }

        public override void Status()
        {
            Console.WriteLine("Motorbike is in good condition.");
        }
    }

    class Truck : Vehicle
    {
        public Truck()
        {
            VehicleName = "Truck";
            VehicleId = "TR001";
        }

        public override void Status()
        {
            Console.WriteLine("Truck is being serviced.");
        }
    }

    class Car : Vehicle
    {
        public Car()
        {
            VehicleName = "Car";
            VehicleId = "CR001";
        }

        public override void Status()
        {
            Console.WriteLine("Car is ready for use.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create object
            Vehicle obj1 = new Motorbike();
            Vehicle obj2 = new Truck();
            Vehicle obj3 = new Car();

            // Display the information
            obj1.ShowInfo();
            obj1.Status();

            obj2.ShowInfo();
            obj2.Status();

            obj3.ShowInfo();
            obj3.Status();

            //total variable count
            Console.WriteLine($"Total vehicles created: {Vehicle.vehicleCount}");
        }
    }
}



//2nd lab task

using System;
namespace Inheritance
{
    public class Person
    {
        private string name;
        private string dob;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public Person()
        {
            //This is called difalut constractor
        }
        public Person(string name, string dob)
        {
            this.name = name;
            this.dob = dob;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setDob(string dob)
        {
            this.dob = dob;
        }
        public string getDob()
        {
            return dob;
        }
    }
    public class Account
    {
        private int account_id;
        private double amount;
        private string account_type;

        public int Account_id
        {
            get
            {
                return account_id;
            }
            set
            {
                this.Account_id = value;
            }
        }
        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                this.Amount = value;
            }
        }
        public string Account_Type
        {
            get
            {
                return account_type;
            }
            set
            {
                this.account_type = value;
            }
        }
        public Account(int account_id, double amount, string account_type)
        {
            this.account_id = account_id;
            this.amount = amount;
            this.account_type = account_type;
        }
    }
    public class Employe : Person
    {
        private Account acc;
        public Employe()
        {
            //This is called difalut constractor
        }
        public Employe(string name, string dob, int account_id, double amount, string account_type) : base(name, dob)
        {
            this.acc = new Account(account_id, amount, account_type);
        }
        public void Display()
        {
            Console.WriteLine("The Employe name            : " + getName());
            Console.WriteLine("The Employe dob             : " + getDob());
            Console.WriteLine("The Employe Account Number  : " + acc.Account_id);
            Console.WriteLine("The Employe Account Balance : " + acc.Amount);
            Console.WriteLine("The Employe Account Type    : " + acc.Account_Type);
        }
    }
    public class Customer : Person
    {
        private Account acc;
        public Customer()
        {
            //This is called difalut constractor
        }
        public Customer(string name, string dob, int account_id, double amount, string account_type) : base(name, dob)
        {
            this.acc = new Account(account_id, amount, account_type);
        }
        public void Display()
        {
            Console.WriteLine("The Customer name            : " + getName());
            Console.WriteLine("    Customer dob             : " + getDob());
            Console.WriteLine("    Customer Account Number  : " + acc.Account_id);
            Console.WriteLine("    Customer Account Balance : " + acc.Amount);
            Console.WriteLine("    Customer Account Type    : " + acc.Account_Type);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe obj1 = new Employe("Nitu", "18-02-2004", 16555874, 2000000.00, "Personal");
            Employe obj2 = new Employe("Mitu", "22-06-2004", 11414168, 100000.00, "Personal");
        

            Customer obj3 = new Customer("Farzana", "21-08-2004", 13158716, 5000000.00, "Savings");
            Customer obj4 = new Customer("Akhi", "13-06-1999", 984513202, 5589335.21, "Political");


            obj1.Display();
            Console.WriteLine();
            obj2.Display();
            Console.WriteLine();
            obj3.Display();
            Console.WriteLine();
            obj4.Display();
            Console.WriteLine();
        }
    }
}
