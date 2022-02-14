using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_alpha_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter alphabet,number or symbol");
            char ch2 = Convert.ToChar (Console.ReadLine());
            if ((ch2 >= 65 && ch2 <= 90 || ch2 >= 97 && ch2 <= 122))
            {
                Console.WriteLine("It's a alphabet");
            }
               else if (ch2 >= 48 && ch2 <= 57)
                {
                    Console.WriteLine("It's a digit");
                }

             else if ((ch2 >= 32 && ch2 <= 64 ) || (ch2 >=91 && ch2<=96) ||(ch2 >=123 && ch2<=126) ||
                ch2>=145 &&ch2<=152)
                {
                    Console.WriteLine("It's a symbol");
                }
            

            else
            {
                Console.WriteLine("Incorrect syntax");
            }
            

            Console.ReadKey();
        }
            
        }
    }

