using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial program");
            int fact = 1;

            for (int j = 1; j <= 5; j++) ;
            {
           
                fact *= j;
            }
            Console.WriteLine(fact);

            Console.ReadKey();
        }
    }
}
