/*using System;
using System.Globalization;
using System.Buffers;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string id;
            Console.WriteLine("Enter your id");
            id = Console.ReadLine();
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("id is: "+id);
            Console.WriteLine("Username is: " + userName);
        }
    }
}*/
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 28;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
                Console.WriteLine("y is greater then x");
        }
    }
}*/
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;               // integer (whole number)
            long mylong = myNum;
        
            //Console.WriteLine(myLong
           Console.WriteLine(myNum);
            Console.WriteLine(mylong);
            //Console.WriteLine(mylong);
            //Console.WriteLine(number);
            //Console.WriteLine(myDoubleNum);
            //Console.WriteLine(myLetter);
            //Console.WriteLine(myBool);
            //Console.WriteLine(myText);
        }
    }
}*/
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                case 8:
                    Console.WriteLine("monday");
                    break;            }
        }
    }
}*/
/*

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);
        }
    }
}*/
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string response="connection_failed";
            if (response == "connection_faied")
            {
                Console.WriteLine("is statement execute");
            }
            else
            {
             
                Console.WriteLine("else");
            }
        }
    }
}*/

///for loop
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
           
            for ( i = 1; i <= 10; i = i + 2)
            {
                Console.Write(i);
            }
        }
    }
*/
/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_E
{
    public class Account
    {
        private int id;
        private string name;
        private string email;
        private string branch;
        private float balance;
        /// <summary>
        /// Constractor
        /// </summary>
        public Account()
        {
            
        }
        public Account(int id, string name, string email, string branch, float balance)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.branch = branch;
            this.balance = balance;
        }
        public void withdraw(float amount)
        { 
            this.balance = amount;
        }
        public void deposit(float amount) 
        {
            this.balance = amount;
        }
        public void display(float amount)
        {
            this.balance = amount;
        }
        public struct Student
        {
            private string studentID;
            public string StudentID
            {
                get
                {
                    return this.studentID;
                }
                set
                {
                    this.studentID = value;
                }
            }

            public string Name;
            public float Cgpa;
            public int NOC;

            public Student(string id, string name, float cgpa, int noc)
            {
                studentID = id;
                Name = name;
                Cgpa = cgpa;
                NOC = noc;
            }

        }
        internal class Program
        {

            public static void go(int a, int b = 1, int c = 0)
            { Console.WriteLine(a + "," + b + "," + c); }
            public static void oop2(out int x, out int y)
            {
                x = 10;
                y = 20;
            }
            public static void A(ref int x, ref int y)
            {
                x += 10;
                y -= 20;
            }
            /*
            public static void GetAPrint(string n)
            {
                Console.WriteLine(n);
            }
            */
/*
            static void Main(string[] args)
            {
                Account a1 = new Account();
                /*
            Student s1 = new Student("23-xxxxx-1","Sikder",3.5f, 115);
            s1.StudentID = "22-XXXXX-1";    
            Console.WriteLine(s1.StudentID);
            /*
            s1.StudentID = "23-XXXXX-3";
            s1.Name = "Prottoy";
            s1.Cgpa = 4.0f;
            s1.NOC = 111;
            */
//Console.WriteLine(s1.Name + "'s cgpa is:" + s1.Cgpa);            /*
/*
int[][] jarray = new int[5][];
jarray[0] = new int[2] { 1, 4 };
jarray[1] = new int[5] { 23, 78, 90, 11, 5 };
jarray[2] = new int[3] { 90, 11, 5 };
jarray[3] = new int[2] { 11, 5 };
jarray[4] = new int[1] { 23 };
for (int i = 0; i < 5; i++)
{
    foreach (int j in jarray[i])
    {
        Console.Write(j + " ");
    }
    Console.WriteLine("");
}

/*
int[,] a = new int[2, 2] { { 10, 20 }, { 30, 40 } };
for(int i = 0; i < 2; i++)
{
for(int j=0;j<2;j++)
{
Console.Write(a[i,j]+" ");
}
Console.WriteLine("");
}
/*
int[] a1 = new int[10];

for(int i=0;i<10;i++)
{
a1[i]= Convert.ToInt32(Console.ReadLine());
}

foreach (int i in a1)
{
Console.WriteLine(i);
}.

float[] b2=new float[5] {5.6f,8.9f,2.3f,5.6f,7.1f};//array declaration & initialization
foreach (float i in b2)
{
Console.WriteLine(i);
}
//go(12, c:13); //A=12,b=1,c=13
//go(12, 13,25);
//int a, b;
//oop2 (out a, out b);
/*
int a1 = 90, b1 = 20;
Console.WriteLine("a1:" + a1 + " b1:" + b1);
A(ref a1, ref b1);
Console.WriteLine("a1:" + a1 + " b1:" + b1);
//Console.WriteLine("a:"+a+" b:"+b);
//string input=Console.ReadLine();
//GetAPrint(input);
/*
int[] arr=new int[5] {23,11,45,65,78};
foreach (int a in arr)
{
if(a%2==0)
Console.WriteLine(a);
}
/*
for (int i = 1; i <= 10; i++)
{
Console.WriteLine(i);
}
/*
int i = 1;
do
{
Console.WriteLine(i);
i++;
}while (i<=10);
/*
int i = 1;
while(i<=10)
{
Console.WriteLine(i);
i++;
}
//float f = 2.5f;
/*
int n1,n2;
char opt;
Console.Write("Enter the first number:");
n1=Convert.ToInt32(Console.ReadLine());
Console.Write("\n Enter the second number:");
n2=Convert.ToInt32(Console.ReadLine());
opt=Convert.ToChar(Console.ReadLine());
switch (opt)
{
case '+':
Console.WriteLine("The summation is:" + (n1 + n2));
break;
case '-':
Console.WriteLine("The subtraction is:" + (n1 - n2));
break;
case '*':
Console.WriteLine("The multiplication is:" + (n1 * n2));
break;
case '/':
if (n2 == 0)
Console.WriteLine("the second number cannot be 0");
else 
Console.WriteLine("The division is:" + (n1 / n2));
break;
default:
Console.WriteLine("The operator is invalid");
break;
}
/*
float cgpa;
Console.WriteLine("Enter your cgpa:");
cgpa=Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Please enter your name:");
string name=Console.ReadLine();
Console.WriteLine("Enter the number of credits you've completed:");
int noc;
noc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(name+" has cgpa:"+cgpa+" and has completed "+noc+" credits");
*/
//Console.Write("Hello OOP2_E");
/*
Console.WriteLine("Hello world");
Console.WriteLine("Hello world");
*/
/*
}
}
}
}
*/

///lab task
/*

using System;

namespace VehicleApp
{
    //This is for base class
     public class Vehicle
    {
        // Member fields
        public string vehicleName;
        private string vehicleId;
        public static int vehicleCount=0;

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
            Console.WriteLine("Vehicle Name: "+vehicleName+", Vehicle ID: "+vehicleId);
        }
    }

    // Derived classes
    class Motorbike : Vehicle
    {
        public Motorbike()
        {
            vehicleName = "Motorbike";
        
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
            vehicleName = "Truck";
          
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
            vehicleName = "Car";
            //VehicleId = "CR001";
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
            //vehicleID

            obj1.VehicleId = "01";
            obj2.VehicleId = "02";
            obj3.VehicleId = "03";

            //showinfo
            
            obj1.ShowInfo();
            obj1.Status();

            obj2.ShowInfo();
            obj2.Status();

            obj3.ShowInfo();
            obj3.Status();

            //total variable count
            Console.WriteLine("Total vehicles created: "+Vehicle.vehicleCount);
        }
    }
}*/


/*
///for each loop
///


using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}*/

/*
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
            Console.WriteLine("Employe Name            : " + getName());
            Console.WriteLine("Employe DOB             : " + getDob());
            Console.WriteLine("Employe Account Number  : " + acc.Account_id);
            Console.WriteLine("Employe Account Balance : " + acc.Amount);
            Console.WriteLine("Employe Account Type    : " + acc.Account_Type);
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
            Console.WriteLine("Customer Name            : " + getName());
            Console.WriteLine("Customer DOB             : " + getDob());
            Console.WriteLine("Customer Account Number  : " + acc.Account_id);
            Console.WriteLine("Customer Account Balance : " + acc.Amount);
            Console.WriteLine("Customer Account Type    : " + acc.Account_Type);
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
           co
            cust.Display();
        }
    }
}

*/

/*

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
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Account
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int AccountNumber { get; private set; }
        public float AccountBalance { get; private set; }

        public Account(string name, string email, int accountNumber, float accountBalance)
        {
            this.Name = name;
            this.Email = email;
            this. AccountNumber = accountNumber;
            this.AccountBalance = accountBalance;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account Information:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Balance: " + string.Format("${0}", AccountBalance));
            //Console.ReadLine("Account Information:");
            //Console.ReadLine("Name: " + Name);
            //Console.ReadLine("Email: " + Email);
            //Console.ReadLine("Account Number: " + AccountNumber);
            //Console.ReadLine("Account Balance: " + string.Format("${0}", AccountBalance));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Faiyaz Azmaine", "faiyazazmaine@gmail.com", 123456, 1500);

            account.DisplayAccountInfo();
        }
    }
}
*/

/*
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace LabTask2._1
{
    public class Vehical
    {
        private string vehicalName;
        private string vehicalId;

        public string VehicalId
        {
            get

            {
                return vehicalId;

            }

            set
            {
                this.VehicalId = value;
            }
        }
        public string VehicalName
        {
            get
            {
                return vehicalName;

            }
            set
            {
                this.VehicalName = value;
            }
        }

        public static void status()
        {
            Console.WriteLine("Status Function Called");

        }

        public static void showinfo()
        {
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
*/
/* 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace LabTask2._2
{

    class Vehicle
    {
        private string vehicleName;
        private string vehicleId;


        public static int vehicleCount = 0;


        public Vehicle()
        {
            vehicleName = "Unknown";
            vehicleId = "Unknown";
            vehicleCount++;
        }


        public string VehicleName
        {
            get { return vehicleName; }
            set { vehicleName = value; }
        }

        public string VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }


        public virtual void Status()
        {
            Console.WriteLine("Vehicle is in good condition.");
            Console.WriteLine();
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Vehicle Name: {vehicleName}, Vehicle ID: {vehicleId}");
        }
    }


    class Motorbike : Vehicle
    {
        public Motorbike()
        {
            VehicleName = "Yahama FZ V3";
            VehicleId = "MB01";
        }

        public override void Status()
        {
            Console.WriteLine("Motorbike is ready to RIDE");
        }
    }

    class Truck : Vehicle
    {
        public Truck()
        {
            VehicleName = "Marcedes Bens Truck";
            VehicleId = "TR01";
        }

        public override void Status()
        {
            Console.WriteLine("Truck is ready to transport goods");
        }
    }
    class CAR : Vehicle
    {
        public CAR()
        {
            VehicleName = "Honda Civic 2018";
            VehicleId = "CAR01";
        }

        public override void Status()
        {
            Console.WriteLine("CAR is ready for DRIVE");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Vehicle obj1 = new Motorbike();
            Vehicle obj2 = new Truck();
            Vehicle obj3 = new CAR();

            obj1.ShowInfo();
            obj1.Status();

            obj2.ShowInfo();
            obj2.Status();

            obj3.ShowInfo();
            obj3.Status();


            Console.WriteLine();
            Console.WriteLine($"Total vehicles Count: {Vehicle.vehicleCount}");
        }
    }
}*/

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_PERFORMANCE
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
           Console.WriteLine("Default Constractor Called");
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
       public void setdob(string dob)
       {
           this.dob = dob;
       }
       public string getdob()
       {
           return this.dob;
       }
   }
   public class Account
   {
       private long account_id;
       private double amount;
       private string account_type;

       public long Account_id
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
       public Account(
           int account_id,
           double amount,
           string account_type)
       {
           this.account_id = account_id;
           this.amount = amount;
           this.account_type = account_type;
       }
   }
   public class Employee : Person
   {
       private Account acc;
       public Employee()
       {
           Console.WriteLine("Default Constractor Called");
       }
       public Employee(
           string name,
           string dob,
           int account_id,
           double amount,
           string account_type) : base(name, dob)
       {
           this.acc = new Account(account_id, amount, account_type);
       }
       public void Display()
       {
           Console.WriteLine("Employee Details         : ");
           Console.WriteLine(" ");
           Console.WriteLine("Employee Name            : " + getName());
           Console.WriteLine("Employee DOB             : " + getdob());
           Console.WriteLine("Employee Account Number  : " + acc.Account_id);
           Console.WriteLine("Employee Account Balance : " + acc.Amount);
           Console.WriteLine("Employee Account Type    : " + acc.Account_Type);
       }
   }
   public class Customer : Person
   {
       private Account acc;
       public Customer()
       {
           Console.WriteLine("Default Constractor Called");
       }
       public Customer(
           string name,
           string dob,
           int account_id,
           double amount,
           string account_type) : base(name, dob)
       {
           this.acc = new Account(account_id, amount, account_type);
       }
       public void Display()
       {
           Console.WriteLine("Customer Details         :  ");
           Console.WriteLine(" ");
           Console.WriteLine("Customer Name            : " + getName());
           Console.WriteLine("Customer DOB             : " + getdob());
           Console.WriteLine("Customer Account Number  : " + acc.Account_id);
           Console.WriteLine("Customer Account Balance : " + acc.Amount);
           Console.WriteLine("Customer Account Type    : " + acc.Account_Type);
       }
   }
   internal class Program
   {
       static void Main(string[] args)
       {

           Customer obj1 = new Customer("Mehedi", "08/06/2010", 13579876, 50000.00, "Savings");

           Employee obj2 = new Employee("Faiyaz", "13/12/1970", 12345678, 2000123.32, "Cureent");
           Employee obj3 = new Employee("Prince", "15/06/1995", 87654321, 150324.12, "Business");


           obj1.Display();
           Console.WriteLine();
           obj2.Display();
           Console.WriteLine();
           obj3.Display();
           Console.WriteLine();
       }
   }
}
*/

/*using System;

class Game_Character
{
    // Protected members
    protected double Attackpoint;
    protected double Defensepoint;

    // Constructor to initialize attack and defense points
    public Game_Character(double attack = 0, double defense = 0)
    {
        Attackpoint = attack;
        Defensepoint = defense;
    }

    // Method to calculate the hitpoint (damage)
    public double Hitpoint()
    {
        return (Attackpoint * 2) - (Defensepoint * 0.5);
    }
}

class Ally : Game_Character
{
    // Default constructor
    public Ally() : base()
    {
        Console.WriteLine("I am Ally");
    }

    // Display method
    public void Display()
    {
        Console.WriteLine("Ally Info:");
        Console.WriteLine("Attack Points: "+Attackpoint);
        Console.WriteLine("Defense Points: "+Defensepoint);
        Console.WriteLine("Hitpoint (Damage): "+Hitpoint());
    }
}

class Enemy : Game_Character
{
    // Protected member
    protected string Enemytype;

    // Default constructor
    public Enemy() : base()
    {
        Console.WriteLine("I am Enemy");
        Enemytype = "Generic Enemy";
    }

    // Display method
    public void Display()
    {
        Console.WriteLine("Enemy Info:");
        Console.WriteLine("Enemy Type: "+Enemytype);
        Console.WriteLine("Attack Points: "+Attackpoint);
        Console.WriteLine("Defense Points: "+Defensepoint);
        Console.WriteLine("Hitpoint (Damage): "+Hitpoint());
    }
}

class Boss_Enemy : Enemy
{
    // Default constructor
    public Boss_Enemy()
    {
        Console.WriteLine("I am Boss Enemy");
        Enemytype = "Boss";
    }

    // Parameterized constructor to set values
    public Boss_Enemy(double attack, double defense, string type)
        : base()
    {
        Attackpoint = attack;
        Defensepoint = defense;
        Enemytype = type;
        Console.WriteLine("Boss Enemy Created with Custom Values");
    }

    // Display method
    public new void Display()
    {
        Console.WriteLine("Boss Enemy Info:");
        Console.WriteLine("Enemy Type: "+Enemytype);
        Console.WriteLine("Attack Points: "+Attackpoint);
        Console.WriteLine("Defense Points: "+Defensepoint);
        Console.WriteLine("Hitpoint (Damage): "+Hitpoint());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Ally
        Ally ally = new Ally();
        ally.Display();
        Console.WriteLine();

        // Create an instance of Enemy
        Enemy enemy = new Enemy();
        enemy.Display();
        Console.WriteLine();

        // Create an instance of Boss_Enemy with default values
        Boss_Enemy bossEnemy = new Boss_Enemy();
        bossEnemy.Display();
        Console.WriteLine();

        // Create an instance of Boss_Enemy with custom values
        Boss_Enemy customBoss = new Boss_Enemy(50, 30, "Custom Boss");
        customBoss.Display();
    }
}

*/

/*
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
}*/

///Indexer
/*
using System;

public class Menu
{
    private string[] beverages; // Internal array to store beverages.

    // Constructor to initialize the beverages array.
    public Menu(int size)
    {
        beverages = new string[size];
    }

    // Indexer to get or set beverages using an index.
    public string this[int index]
    {
        get
        {
            // Check for valid index.
            if (index >= 0 && index < beverages.Length)
            {
                return beverages[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }
        }
        set
        {
            // Check for valid index.
            if (index >= 0 && index < beverages.Length)
            {
                beverages[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }
        }
    }

    // Property to get the total number of beverages.
    public int Count
    {
        get { return beverages.Length; }
    }
}

class Program
{
    static void Main()
    {
        // Create a Menu object for 3 beverages.
        Menu menu = new Menu(3);

        // Add beverages using the indexer.
        menu[0] = "Americano";
        menu[1] = "Latte";
        menu[2] = "Cappuccino";

        // Access beverages using the indexer.
        Console.WriteLine("Beverages in the menu:");
        for (int i = 0; i < menu.Count; i++)
        {
            Console.WriteLine(menu[i]);
        }

        // Example of invalid index.
        try
        {
            Console.WriteLine(menu[5]); // This will throw an IndexOutOfRangeException.
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}*/
/*

///indexer

using System;

public class FruitBasket  
{
    private string[] fruits = new string[5]; // Array to store 5 fruits.

    // Indexer to get or set fruit names using an index.
    public string this[int index]
    {
        get
        {
            return fruits[index]; // Get the fruit at the specified index.
        }
        set
        {
            fruits[index] = value; // Set the fruit at the specified index.
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of FruitBasket.
        FruitBasket basket = new FruitBasket();

        // Add fruits using the indexer.
        basket[0] = "Apple";
        basket[1] = "Banana";
        basket[2] = "Cherry";
        basket[3] = "no name";
        basket[4] = "ther is a name";
        //basket[5] = "nitu";
        // Retrieve and print the fruits using the indexer.
        Console.WriteLine("Fruits in the basket:");
        Console.WriteLine(basket[0]); // Output: Apple
        Console.WriteLine(basket[1]); // Output: Banana
        Console.WriteLine(basket[2]); // Output: Cherry
        //Console.WriteLine(basket[3]);
       //Console.WriteLine(basket[4]);
        //Console.WriteLine(basket[5]);
    }
}
*/

/*
///Abstract Class

using System;

abstract class Animal
{
    // Abstract method (no implementation)
    public abstract void MakeSound();

    // Concrete method (has implementation)
    public void Sleep()
    {
        Console.WriteLine("The animal is sleeping.");
    }
}

class Dog : Animal
{
    // Implement the abstract method
    public override void MakeSound()
    {
        Console.WriteLine("The dog says: Woof!");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog(); // Create an object of the derived class
        
        myDog.Sleep();         // Call the concrete method from the base class
        myDog.MakeSound();     // Call the implemented abstract method
    }
}*/

/*
///Interface

using System;

// Define the interface
public interface IVehicle
{
    void Start(); // Method signature
    void Stop();  // Method signature
    string Model { get; set; } // Property
}

// Car class implementing the IVehicle interface
public class Car : IVehicle
{
    //public Car{};
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine($"The car {Model} is starting.");
    }

    public void Stop()
    {
        Console.WriteLine($"The car {Model} is stopping.");
    }
}

// Bike class implementing the IVehicle interface
public class Bike : IVehicle
{
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine($"The bike {Model} is starting.");
    }

    public void Stop()
    {
        Console.WriteLine($"The bike {Model} is stopping.");
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Create objects of Car and Bike
        IVehicle myCar = new Car { Model = "Toyota Corolla" };
        IVehicle myBike = new Bike { Model = "Yamaha R15" };

        // Use the interface methods
        myCar.Start();  // Output: The car Toyota Corolla is starting.
        myCar.Stop();   // Output: The car Toyota Corolla is stopping.

        myBike.Start(); // Output: The bike Yamaha R15 is starting.
        myBike.Stop();  // Output: The bike Yamaha R15 is stopping.
    }
}
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
        private void LoadData()
        {
            string connectionString = @"Data Source=DESKTOP-OCNS2DA\SQLEXPRESS;Initial Catalog=ESMSDb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from Teacher";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            /*
            if (toolStripProgressBar1.Value != 100)
                toolStripProgressBar1.Value += 20;
            else
                MessageBox.Show("Task completed!");
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(id);
                textBox1.Text = id;
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-OCNS2DA\SQLEXPRESS;Initial Catalog=ESMSDb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "update Teacher set Name='" + textBox2.Text + "', Email='" + textBox3.Text + "' where id=" + textBox1.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            LoadData();
        }
    }
}