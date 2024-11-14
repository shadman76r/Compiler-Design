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
