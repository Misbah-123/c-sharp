using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    class Program
    {
        static void Main(string[] args)

        {
            int year, i;
            for (year = 2001; year <= 2022; year++)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("Its a leap year" + year);
                }
                else
                {
                    Console.WriteLine("Its not a leap year" + year);
                }
            }

            for (i = 100; i >= 0; i--)
            {


                Console.WriteLine("Counting  " + i);

            }


            Console.ReadKey();
        }
    }
}
