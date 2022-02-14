using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marksheet
{
    class Program
    {
        static void Main(string[] args)
        {
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
            per = total / 3.0f;

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

            Console.ReadKey();
        }
    }
}
