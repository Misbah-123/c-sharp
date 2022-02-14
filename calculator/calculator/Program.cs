using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("misbah");
            Console.WriteLine("Add program");
            Console.WriteLine("Enter first number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = num1 + num;
            Console.WriteLine("Ans is" + num2);


            Console.WriteLine("Sub program");
            Console.WriteLine("Enter first number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = num3 - num4;
            Console.WriteLine("Ans is" + num5);

            Console.WriteLine("Div program");
            Console.WriteLine("Enter first number");
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num7 = Convert.ToInt32(Console.ReadLine());
            int num8 = num6 / num7;
            Console.WriteLine("Ans is" + num8);

            Console.WriteLine("Multiply program");
            Console.WriteLine("Enter first number");
            int num9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num10 = Convert.ToInt32(Console.ReadLine());
            int num11 = num9 * num10;
            Console.WriteLine("Ans is " + num11);

            Console.ReadKey();
        }

    }
}

