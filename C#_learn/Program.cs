
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------DATATYPES------------------------------------------------------:

            Console.Write("Enter an integer: ");
            int intValue = int.Parse(Console.ReadLine());

            // Double input
            Console.Write("Enter a double: ");
            double doubleValue = double.Parse(Console.ReadLine());

            // Boolean input
            Console.Write("Enter true or false: ");
            bool boolValue = bool.Parse(Console.ReadLine());

            // Char input
            Console.Write("Enter a character: ");
            char charValue = Console.ReadLine()[0]; // Takes first character of input

            // String input
            Console.Write("Enter a string: ");
            string stringValue = Console.ReadLine();

            // Display values
            Console.WriteLine($"Integer: {intValue}, Double: {doubleValue}, Boolean: {boolValue}, Char: {charValue}, String: {stringValue}");



            ////---------------------------------------------------------OPERATORS:--------------------------------------------------
            int a = 10, b = 5;
            bool x = true, y = false;

            //// Arithmetic Operators
            Console.WriteLine($"Addition: {a + b}");  // 15
            Console.WriteLine($"Subtraction: {a - b}"); // 5
            Console.WriteLine($"Multiplication: {a * b}"); // 50
            Console.WriteLine($"Division: {a / b}"); // 2
            Console.WriteLine($"Modulus: {a % b}"); // 0

            // Relational Operators
            Console.WriteLine($"Equal: {a == b}"); // False
            Console.WriteLine($"Not Equal: {a != b}"); // True
            Console.WriteLine($"Greater Than: {a > b}"); // True

            // Logical Operators
            Console.WriteLine($"AND: {x && y}"); // False
            Console.WriteLine($"OR: {x || y}"); // True
            Console.WriteLine($"NOT: {!x}"); // False

            // Assignment Operators
            a += 5;  // Equivalent to a = a + 5
            Console.WriteLine($"New Value of a: {a}"); // 15

            //Ternary Operators
            int num = 10;
            string result = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"The number is {result}");


            ////----------------------------------------------------------CONTROL STATEMENTS:---------------------------------------------------
            ////if ,if-Else(nested), switch
            //// if-else assignments

            Console.WriteLine("Enter your Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Show Timing(matinee/evening):");
            string Show_time = Console.ReadLine();
            int ticket_price = 0;
            if (age < 12)
                Console.WriteLine("invalid age");
            if (Show_time == "matinee" || Show_time == "evening")
            {
                if (age <= 12)
                {
                    if (Show_time == "matinee")
                        Console.WriteLine($"ticket price: rs.{ticket_price}");
                    else
                        Console.WriteLine($"ticket price rs.{ticket_price}");

                }
                else if (age >= 13 && age <= 59)
                {
                    ticket_price = (Show_time == "matinee") ? 100 : 120;
                }
                else if (age >= 60)
                {
                    ticket_price = (Show_time == "matinee") ? 60 : 80;
                }
                Console.WriteLine($"Ticket price:Rs. {ticket_price}");
            }
            else
            {
                Console.WriteLine("Invalid Response");
            }
            //--------------------------------------------------------LOOPINGS-------------------------------------------------
            //for, do-while,while
            //FORLOOP
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine("series of num:" + sum);

            //----------------------------------WHILE LOOP-------------------------------

            int num2 = 20;
            int i = 0;
            while (i<num)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            //--------------------------------------------do-while-------------------------------


            int num3 = 20;
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < num3);

            //--------------------------------------------------------ARRAYS------------------------------------------------
            int[] arr = new int[5];
            arr[0] = 23;
            arr[1] = 24;
            int[] arr1 = new int[] { 12, 3, 45, 674 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }
            //-----------------------------ARRAY IN STRING------------------
            int num = Convert.ToInt32(Console.ReadLine());
            string[] strarray = new string[num];
            Console.WriteLine("enter the students name:");
            for (int i = 0; i < num; i++)
            {
                strarray[i] = Console.ReadLine();
            }
            Console.WriteLine("print the studnet list:");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(strarray[i]);
            }
            Console.WriteLine($"length of array {strarray.Length}");
            Array.Reverse(strarray);
            foreach (var item in strarray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            //---------------------------------TWO-DIMENSIONAL ARRAY-------------------------------
            int[,] myarr = new int[2, 3];
            Console.WriteLine("enter the values:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myarr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("prit the integer values:");
            for (int i = 0; i < 2; i++)
            {
                for (global::System.Int32 j = 0; j < 3; j++)
                {
                    Console.WriteLine(myarr[i, j] + " ");
                }

            }

            //-----------------------------------------------JAGGED ARRAY-------------------------------------------------
            Console.WriteLine("Enter the number of classes");
            int numberofclass = Convert.ToInt32(Console.ReadLine());
            string[][] school = new string[numberofclass][];
            for (int i = 0; i < numberofclass; i++)
            {
                Console.WriteLine($"enter the number of students for class {i + 1}");
                int numofstudents = Convert.ToInt32(Console.ReadLine());
                school[i] = new string[numofstudents];
                for (int j = 0; j < numofstudents; j++)
                {
                    Console.WriteLine($"enter the name of student {j + 1} in class {i + 1}");
                    school[i][j] = Console.ReadLine();

                }

            }
            Console.WriteLine("\n****************student list*************");
            for (int i = 0; i < school.Length; i++)
            {
                Console.WriteLine($"\n class {i + 1}:");
                for (int j = 0; j < school[i].Length; j++)
                {
                    Console.WriteLine($" -{school[i][j]}");
                }
            }
            Console.ReadLine();

            // ------------------------------------
            static void order(string size, string stuffed, string topping = "cheese")
            {
                Console.WriteLine($" size ={size} stuffed={stuffed} topping ={topping}");
            }
            static void Main(string[] args)
            {
                order(size: "medium", stuffed: "panner" , topping :" butter");


            }
            //-------------------------------



        }
    }
}