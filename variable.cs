using System;
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
}
/*using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace MyApplication
{ 
   class Program
    {
        static void Main(int[] args)
        {
            int  x=78;
            Console.WriteLine("Enter first number:");
     
            int y;
            Console.WriteLine("Enter second number:");
            y= Console.ReadLine();
            if (x>y)
            {
                Console.WriteLine("x is greater than y");
            }
            else {
                Console.WriteLine("Y is greater than x");
            }
        }
    }
}*/

/*using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;               // integer (whole number)
            long number = 40000000000000000; //same as integer but take more value
            double myDoubleNum = 5.99D;  // floating point number
            char myLetter = 'D';         // character
            bool myBool = true;          // boolean
            string myText = "Hello";     // string
            long myLong = 6888888855;
            Console.WriteLine(myLong);
            Console.WriteLine(myNum);
            Console.WriteLine(number);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);
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
            int day = 8;
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
}
//loop

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
}
///c# code
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
        { }
        public void deposit(float amount) { }
        public void display()
        { }
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
            }
        }
    }
}
