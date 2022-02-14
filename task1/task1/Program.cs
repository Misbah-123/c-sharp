using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Upper or Lower case");
            char ab = Convert.ToChar(Console.ReadLine());

            if ((ab >= 65 && ab <= 90))
            { char convert = (char)(ab + 32);
              Console.WriteLine("convert in lowercase :" + convert);
            }

             else if ((ab >= 97 && ab <= 122))
            {
                char convert = (char)(ab - 32);
                Console.WriteLine("convert in uppercase :" + convert);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }


        }
    }

