using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upper_lower_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select capital or small alphabet");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 65 && ch <= 90)
            {
                Console.WriteLine("It's a upper case");
            }
             else  if (ch >= 97 && ch <= 122)
                {
                    Console.WriteLine("It's a lower case");
                }
            
            else
            {
                Console.WriteLine("Invalid option");
            }
            Console.ReadKey();
        }
    }
}
