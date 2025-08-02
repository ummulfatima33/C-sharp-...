using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Construct_selectionConstructs_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=========If========
                 //(1)
            int a = -5;
            if (a < 0)
            {
                Console.WriteLine("Number is negative");
            }

            Console.WriteLine("----------------------");

            //=========If Else========
                         //(1) 

            int b = 50;
            int c = 125;
            if (b < c   )
            {
                Console.WriteLine("Number is positive");
               }   else {
                Console.WriteLine("Number is negative");
                 }

            Console.WriteLine("----------------------");

            //(2)

            Console.Write("Set Username???");
            string uname = Console.ReadLine();


            Console.Write("Set Password???");
            int upassword = int.Parse(Console.ReadLine());


            Console.WriteLine("======= Login ========");

            Console.Write("Enter Username.....");
            string inputname = Console.ReadLine();

            Console.Write("Enter Password.....");
            int inputpassword = int.Parse(Console.ReadLine());


            if (inputname == uname & inputpassword == upassword)
            {
                Console.WriteLine("Login successfully");
            }
            else
            {
                Console.WriteLine("Invalid Credentials");
            }


            Console.WriteLine("----------------------");

            //=========If Else If========

                    //(1)

            int num = 13;   //odd
            if (num < 0)
            {
                Console.WriteLine("Number is negative");
            }
               else if((num % 2) == 26)
            {
                Console.WriteLine("Number is even");
            }
                  else
            {
                Console.WriteLine("Number is odd");
            }

            Console.WriteLine("----------------------");

                       //(2)

            int d = 5;    //even
            if (d < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else if ((d + 2) == 7)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

                   Console.ReadKey();
        }
    }
}
