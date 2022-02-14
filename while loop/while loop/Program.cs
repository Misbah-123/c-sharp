using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            while(t <=10)
            {
                if (t % 2 == 0)
                {
                    Console.WriteLine("Even" + t);
                }
                else
                {
                    Console.WriteLine("odd" + t);
                }
                t++;
                }


            int u = 0;
            while (u <= 10)
            {

                Console.WriteLine("mute");

                u++;
            }

            //Console.WriteLine("Enter table number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int j = 1;
            //while( j <= 10)
            //{
            //    Console.WriteLine("{0} * {1} = {2}", n, j, n * j);

            //    j++;
            //}
           
                int i = 1;
                while (i <= 5)
                {

                    Console.WriteLine("Marksheet");

                    Console.WriteLine("Enter Student name");
                    string m = Console.ReadLine();

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

                    if (per >= 70 && per <= 79)
                    {
                        Console.WriteLine("Grade is A");

                    }

                    else if (per >= 60 && per <= 69)
                    {
                        Console.WriteLine("Grade is B");

                    }

                    else if (per >= 50 && per <= 59)
                    {
                        Console.WriteLine("Grade is C");

                    }

                    else if (per < 40)
                    {
                        Console.WriteLine("Fail");

                        i++;

                    }
                }
            
                Console.ReadKey();
            }
        }
    }
