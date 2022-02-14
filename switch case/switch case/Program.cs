using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select operation A,S,M,D");
            char operators =Convert.ToChar(Console.ReadLine());
            switch (operators)
            {
                case 'A':
                    { 
                    Console.WriteLine("Create add function");
                    Console.WriteLine("Enter first num");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second num");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int add = num + num1;
                    Console.WriteLine("Addition is  " + add);
                    break;
                    }

                case 'S':
                    {
                        Console.WriteLine("Create subtract function");
                        Console.WriteLine("Enter first num");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second num");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        int subtract = num2 - num3;
                        Console.WriteLine("Subtraction is  " + subtract);
                        break;
                    }


                case 'M':
                    {
                        Console.WriteLine("Create multiply function");
                        Console.WriteLine("Enter first num");
                        int num4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second num");
                        int num5 = Convert.ToInt32(Console.ReadLine());
                        int multiply = num4 * num5;
                        Console.WriteLine("Multiplication is  " + multiply);
                        break;
                    }


                case 'D':
                    {
                        Console.WriteLine("Create division function");
                        Console.WriteLine("Enter first num");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second num");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        int divide = num2 / num3;
                        Console.WriteLine("Division is  " + divide);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid operator");
                        break;
                    }

            }
            Console.ReadKey();

        }
            
        }
    }

