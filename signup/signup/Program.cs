using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select yes or no");
            string ans = Console.ReadLine();

            if (ans == "yes" || ans == "Yes")
            {
                Console.WriteLine("SignUp");
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your email");
                string email = Console.ReadLine();

                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                Console.WriteLine("Account sucessfully created");

                Console.WriteLine("Login");
                Console.WriteLine("Enter your email");
                string email_ = Console.ReadLine();

                Console.WriteLine("Enter your password");
                string pass = Console.ReadLine();

                if (email == email_ && password == pass)
                {
                    Console.WriteLine("Welcome to my Application");
                    Console.WriteLine("select your operation");
                    char op = Convert.ToChar(Console.ReadLine());

                    switch (op)
                    {
                        case '1':
                            Console.WriteLine("Marksheet");

                            Console.WriteLine("Enter Student name");
                            string n = Console.ReadLine();

                            Console.WriteLine("Enter Maths number");
                            Double num = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Physics number");
                            Double num1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Computer number");
                            Double num2 = Convert.ToDouble(Console.ReadLine());
                            double total, per;
                            total = num + num1 + num2;
                            per = total / 300 * 100;

                            Console.WriteLine("Total" + total);
                            Console.WriteLine("Percentage " + per);

                            if (per >= 80 && per <= 100)
                            {
                                Console.WriteLine("Grade is A+");

                            }

                            if (per >= 70 && per < 80)
                            {
                                Console.WriteLine("Grade is A");

                            }

                            if (per >= 60 && per < 70)
                            {
                                Console.WriteLine("Grade is B");

                            }

                            if (per >= 50 && per < 60)
                            {
                                Console.WriteLine("Grade is C");

                            }

                            if (per < 50)
                            {
                                Console.WriteLine("Fail");

                            }


                            break;



                        case '2':

                            Console.WriteLine("Create Add Program");
                            Console.WriteLine("Enter first number");
                            int num3 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Second number");
                            int num4 = Convert.ToInt32(Console.ReadLine());

                            int add = num3 + num4;
                            Console.WriteLine("Addition is  " + add);


                            Console.WriteLine("Create Subtract Program");
                            Console.WriteLine("Enter first number");
                            int num5 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Second number");
                            int num6 = Convert.ToInt32(Console.ReadLine());

                            int sub = num5 - num6;
                            Console.WriteLine("Subtraction is  " + sub);


                            Console.WriteLine("Create Multiply Program");
                            Console.WriteLine("Enter first number");
                            int num7 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Second number");
                            int num8 = Convert.ToInt32(Console.ReadLine());

                            int multiply = num7 * num8;
                            Console.WriteLine("Multiplication is  " + multiply);


                            Console.WriteLine("Create division Program");
                            Console.WriteLine("Enter first number");
                            int num9 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Second number");
                            int num10 = Convert.ToInt32(Console.ReadLine());

                            int divide = num9 / num10;
                            Console.WriteLine("Division is  " + divide);
                            break;
                        case '3':
                            Console.WriteLine("Select capital or small alphabet");
                            char ch = Convert.ToChar(Console.ReadLine());

                            if (ch >= 65 && ch <= 90)
                            {
                                Console.WriteLine("It's a upper case");
                            }
                            else if (ch >= 97 && ch <= 122)
                            {
                                Console.WriteLine("It's a lower case");
                            }

                            else
                            {
                                Console.WriteLine("Invalid option");
                            }
                                

                            break;

                        case '4':
                            Console.WriteLine("Choose even or odd number");
                            int check = Convert.ToInt32(Console.ReadLine());

                            if (check % 2 == 0)
                            {
                                Console.WriteLine("Even number  " + check);

                            }
                            else
                            {
                                Console.WriteLine("Odd number  " + check);
                            }

                            break;
                        case '5':
                            {
                                Console.WriteLine("Select year");
                                int check1 = Convert.ToInt32(Console.ReadLine());

                                if (check1 % 4 == 0)
                                {
                                    Console.WriteLine("It's a leap year  " + check1);

                                }
                                else
                                {
                                    Console.WriteLine("It's not a leap year  " + check1);
                                }
                            }
                            break;
                        case '6':
                            Console.WriteLine("Enter table value");
                            int table = Convert.ToInt32(Console.ReadLine());
                            int  tb = 1;
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));

                            break;


                    }
                }

                else
                {
                        Console.WriteLine("Incorrect email or password");
                }

            }
            else
            {
                Console.WriteLine("Invalid operation");

            }
            Console.ReadKey();

        }
    }
}
