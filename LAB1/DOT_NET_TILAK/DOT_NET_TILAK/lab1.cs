using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace hello
{
    public struct Rectangle
    {
        public int width, height;
    }
    enum Level
    {
        Low,
        Medium,
        High
    }
    internal class lab1
    {
        static void Arthmetic(int a, int b)
        {
            Console.WriteLine("Arithmetic Operator");
            Console.WriteLine("For A={0} and B={1}",a,b);
            Console.WriteLine("...............................");
            Console.WriteLine("Addition: A + B = " + (a + b));
            Console.WriteLine("Subtraction: A - B = " + (a - b));
            Console.WriteLine("Multiplication: A * B = " + (a * b));
            Console.WriteLine("Division: B / A = {0}", (float)b / a);
            Console.WriteLine("Remainder: A % B = " + (a % b));
            Console.WriteLine("Increment: A++ = {0}", a++); //Post 
            Console.WriteLine("Decrement: B-- = " + --b); //Pre 
            Console.ReadLine();
        }
        static void compare(int a, int b)
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("Comparison Operator");
            if (a == b)
            {
                Console.WriteLine("Given numbers are equal.");
            }
            else if (a < b)
            {
                Console.WriteLine("{0} is less than {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1}", a, b);
            }
        }
        //Function for Logical Operator (Also includes conditional statements)
        static void logical()
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("logical Operators and conditional statements");
            string college;
            string program;
            Console.WriteLine("Entrance of Library");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
            Console.Write("Enter your college Name: ");
            college = Console.ReadLine();
            Console.Write("Enter your program: ");
            program = Console.ReadLine();
            if (college == "BMC" && program == "CSIT")
            {
                Console.WriteLine("Welcome to the Library.");
            }
            else if (college == "BMC" && program != "CSIT")
            {
                Console.WriteLine("You can only visit college premise.");
            }
            else
            {
                Console.WriteLine("Permission denied.");
            }
        }
        static void bitwiseOperations()
        {
            Console.WriteLine("\nBitwise Operations");
            Console.WriteLine("--------------------");
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} | {1} = {2}", a, b, a | b);
            Console.WriteLine("{0} & {1} = {2}", a, b, a & b);
            Console.WriteLine("~{0} = {1}", a, ~a);
            Console.WriteLine("{0} << 1 = {1}", a, a << 1);
            Console.WriteLine("{0} >> 2 = {1}", a, a >> 2);
        }        static void conditional()
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("conditional  Operator:(a ? b : x)");
            string FirstName = "Ramesh";
            string LastName = "";
            Console.WriteLine($"First name ={FirstName}\n Last Name ={LastName}");

            //True statement
            string FullName = (String.IsNullOrEmpty(LastName)) ? FirstName : (FirstName + " " + LastName);
            Console.WriteLine(FullName);
        }

        //SWITCH CASE
        static void SwitchWeekEnd()
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("Switch case");
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    Console.WriteLine("Today is holiday");
                    break;
                default:
                    Console.WriteLine("Let`s join Ramesh Kharbuja class today.");
                    break;
            }
        }

        //for LOOP
        static void forloop()
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("for loop example");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"i = {i}");
                i++;
            }
        }

        //foreachloop
        static void foreachloop()
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("for each loop example");
            string[] city = { "Butwal", "Kirtipur", "Dharan", "KTM" };
            foreach (string x in city)
            {
                Console.Write($"city = {x}");
            }
        }

        //while loop
        static void whileLoop()
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("while loop example");
            int i = 1;
            while (i <= 4)
            {
                Console.Write($"i = {i}");
                i++;
            }
        }
        //do-while loop
        static void doWhileLoop()
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("do-while loop example");
            int x = 0;
            do
            {
                Console.Write($"x = {x}");
                x++;
            } while (x <= 5);
        }        static void jump_goto()
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("jump goto example");
            Console.WriteLine("Jump: Goto statement");
            goto g;
            Console.WriteLine("This line will not be printed on console.");
        g:
            {
                Console.WriteLine("code jumped to this line now.");
            }
        }
        static void jump_break()
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("jump break example");
            for (int i = 1; i <= 6; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine($"this will for for 3== {i} times.");
            }
        }
        static void jump_continue()
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("jump continue example");
            for (int j = 1; j <= 6; j++)
            {
                if (j == 4)
                    continue;
                Console.WriteLine("Hello World " + j);
            }
        }
        //STRUCT
        static void struct_example()
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("struct example");
            Console.WriteLine("Width,height =(4,5)");
            //struct is located outside class in the top
            Rectangle r = new Rectangle();
            r.width = 4;
            r.height = 5;
            Console.WriteLine("Area of Rectangle is: " + (r.width * r.height));
        }
        static void emun_example()
        {
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine("enum example");
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }

        //class example in c#
        public class Person
        {
            // Public properties
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; private set; }
            public string Gender { get; protected set; }
            public string Address { get; internal set; }

            // Private field
            private string _ssn;

            // Protected field
            protected string _email;

            // Internal field
            internal string _phone;

            // Public constructor
            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            // Public method with private access modifier
            public void SetAge(int age)
            {
                if (age >= 0 && age <= 120)
                {
                    Age = age;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 120.");
                }
            }

            // Protected method with internal access modifier
            protected internal void SetGender(string gender)
            {
                if (gender == "Male" || gender == "Female")
                {
                    Gender = gender;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'Male' or 'Female'.");
                }
            }

            // Public method with private set accessor
            public string GetSsn()
            {
                return _ssn;
            }

            // Public method with protected set accessor
            public void SetEmail(string email)
            {
                _email = email;
            }

            // Public method with internal set accessor
            public void SetPhone(string phone)
            {
                _phone = phone;
            }
        }


        static void Main(string[] args)
        {
            Arthmetic(50, 40);
            compare(3, 3);
            logical();
            bitwiseOperations();
            conditional();
            SwitchWeekEnd();
            forloop();
            foreachloop();
            whileLoop();
            doWhileLoop();
            conditional();
            jump_goto();
            jump_break();
            jump_continue();
            struct_example();
            emun_example();
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("Class and Object example with access modifiers");
            // Create a new Person object
            Person person = new Person("Tilak","Parajuli");

            // Set the person's age, SSN, email, and phone
            person.SetAge(30);
            //ssn=social security number
            //person.SetSsn("123-45-6789");
            person.SetEmail("meetilakparajuli122@gmail.com");
            person.SetPhone("+977 9864585656");

            // Print out the person's information
            Console.WriteLine($"{person.FirstName} {person.LastName}is {person.Age} years old.");
            Console.WriteLine($"{person.FirstName}'s SSN is not accessible due to private protection level.");
            Console.WriteLine($"{person.FirstName}'s email is not accessible due to protected protection level.");
            Console.WriteLine($"{person.FirstName}'s phone is {person._phone}.\n");
            Console.ReadKey();
        }
    }
}
