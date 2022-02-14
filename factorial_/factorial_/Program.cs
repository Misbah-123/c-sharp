using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("factorial program");
            int fact = 1;

            for (int k = 1; k <= 5; k++)
            {
                fact *= k;
              
            }
            Console.WriteLine(fact);

            Console.WriteLine("Sum of all numbers");
            int sum = 1;

            for(int l =0; l<=6; l++)
            {
                sum += l;
            } // => sum variable value in 1st iteration = 1; 2nd iteration 3; 3rd iteration = 6; 4th iteration=10; 5th iteration=15
              //1+2+3+4+5=15
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
