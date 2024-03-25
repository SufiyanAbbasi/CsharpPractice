using System.Runtime.InteropServices;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HarryConsoleApp
{
    internal class Program
    {
        //Methods 
        static void greet()
        {
            Console.WriteLine("This is a functions");
        } 
        static void greet2(string fname)
        {
            Console.WriteLine("Good Morning " + fname );
        }
        static float average(int a, int b, int c)
        {
        float sum = a + b + c;
            return sum / 3;
        }
        static void Main(string[] args)
        {
            //Calling Methods
            //greet();
            //greet2("Waqas");
            //Console.WriteLine(average(2,6,8));

            //Data Types
            // String match = "I play Cricket";
            //Console.WriteLine(match);
            //int fifty = 50;
            // Console.Write("I Love  C#");
            //Console.WriteLine("Hello, World!");          
            // Console.WriteLine("Babar  Azam scores " + fifty);
            //int a = 40;
            // float b = 22.5F;
            // bool isRaining = true;
            //char d = 'd';
            //Console.WriteLine(a+b);

            //type casting --- converting value from one data  type to another data type
            //implicit casting -- C# does this for us --char to int to long to float to double
            //explicit casting -- we does it by ourlsef this is example int x = (int) 5.2;
            //int x = (int) 5.2;
            //Console.WriteLine(x);

            //take input from user
            //Console.WriteLine("Enter Your Name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello Welcome " + name);
            //Console.WriteLine("How many candies do you want?");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get four more candies " + (Convert.ToInt32(can) + 4));

            //Operators
            //Assignment Operator
            //int asga = 4;
            //int asgb = asga;
            //asgb += 14;
            //Console.WriteLine(asgb);

            //logical operator
            //Console.WriteLine(true && false);
            //Console.WriteLine(true || false);
            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            //Math Operations
            //int matha = Math.Max(24, 50);
            //Console.WriteLine(matha);
            //int mathb = Math.Min(24, 50);
            //Console.WriteLine(mathb);


            //string operations
            //string shello = "hello this is a string ";
            //Console.WriteLine(shello.Length);
            //Console.WriteLine(shello.ToUpper());
            //Console.WriteLine(shello.ToLower());
            //Console.WriteLine(shello + " Good Work ");
            //Console.WriteLine(string.Concat(shello , " Good Work ") );
            //string sname = Console.ReadLine();  
            //string scandies = Console.ReadLine();
            //Console.WriteLine($"Your name is {sname} and you will get {scandies} candies");

            //Decision Maker if else
            //Console.WriteLine("Enter Your Age");
            //string input = Console.ReadLine();
            //int dage = int.Parse(input);

            ////int dage = 18;
            //if (dage > 19)
            //{
            //    Console.WriteLine("You can vote!");
            //}
            //else if (dage == 18)
            //{
            //    Console.WriteLine("Come On give your first vote");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot vote !");
            //}

            //Loops
            //while loop
            //int i = 0;
            //while (i < 5)
            //{
            //   // Console.WriteLine(i);
            //    Console.WriteLine(i+1);
            //    i++;
            //}
            //for (int i = 0;i<5;i++)
            //{
            //    Console.WriteLine(i+1);
            //}
            //Console.ReadLine();

         
        }
    }
}
