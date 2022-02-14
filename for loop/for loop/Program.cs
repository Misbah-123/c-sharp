using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter table number");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for(int j = 1; j<=10; j++)
            //{
            //    Console.WriteLine("{0} * {1} = {2}", n, j, n * j);
            //}

            //for(int i=1; i<=5; i++)
            //{

            //    Console.WriteLine("Marksheet");

            //    Console.WriteLine("Enter Student name");
            //    string n = Console.ReadLine();

            //    Console.WriteLine("Enter Maths number");
            //    Double num = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Enter Physics number");
            //    Double num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Enter Computer number");
            //    Double num2 = Convert.ToDouble(Console.ReadLine());
            //    double total, per;
            //    total = num + num1 + num2;
            //    per = total/300*100;

            //    Console.WriteLine("Total" + total);
            //    Console.WriteLine("Percentage " + per);

            //    if (per >= 80 && per <= 100)
            //    {
            //        Console.WriteLine("Grade is A+");

            //    }

            //    if (per >= 70 && per <=79)
            //    {
            //        Console.WriteLine("Grade is A");

            //    }

            //   else if (per >= 60 && per <=69)
            //    {
            //        Console.WriteLine("Grade is B");

            //    }

            //   else if (per >= 50 && per <=59)
            //    {
            //        Console.WriteLine("Grade is C");

            //    }

            //   else if (per < 40)
            //    {
            //        Console.WriteLine("Fail");

            //    }

            //}

            Console.Write("enter the numbers and CheckhowmanytimesyournumberhasbeenPrinted  ");
      
                      int num1 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Input the numbers  ");
                int num = Convert.ToInt32(Console.ReadLine());
 
 ​            ​if​(num ​== num1)
                    { 
 ​                count​++​; 
 ​            } 
 ​       
            } 
 ​     Console.Write(​"​your number = ​"​ ​+​ num1 ​+​ ​"​ : Print = ​"​ ​+​ count ​+​ ​"​ times ​"​);
        }

        private static void @if(int num, bool v, int num1)
        {
            throw new NotImplementedException();
        }
    }
}
