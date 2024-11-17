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
