using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace moreOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conditional Operator

                //1) AND &&
            if (50 > 20 && 80 > 60)
            {
                Console.WriteLine("both condition are true");
            }
            else
            {
                Console.WriteLine("both condition are false");
            }

            Console.WriteLine("---------------------------------");

            if (10 > 20 && 80 > 60)
            {
                Console.WriteLine("both condition are true");
            }
            else
            {
                Console.WriteLine("both condition are false");
            }

            Console.WriteLine("-----------------------------------");

            //2) OR ||
            int num = -5;
            if (num > 20  || num > 30) 
            {
                Console.WriteLine("The number does not exist between 1 to 20");
            }
            else
            {
                Console.WriteLine("The number exist between 1 to 20");
            }

            Console.WriteLine("-----------------------------------");
            int abc = 5;
         
            if ( abc < 3 || abc > 30)
            {
                Console.WriteLine(" true");
            }
            else
            {
                Console.WriteLine(" false");
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");

            //  Increment / Decrement Operator
            //POST INCREMENT

            int a = 12;
            Console.WriteLine(" This value is : {0}", a++);
            Console.WriteLine(" This value is : {0}", a);

            //PRE INCREMENT
            Console.WriteLine(" This value is : {0}", ++a);

            Console.WriteLine("-----------------------------------");

            //POST DECREMENT

            int b = 10;
            Console.WriteLine(" This value is : {0}", b--);
            Console.WriteLine(" This value is : {0}", b);

            //PRE DECREMENT
            Console.WriteLine(" This value is : {0}", --b);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");

            //  ASSIGNMENT Operator
            //Compound assignment operator

            int value1 = 10;
            value1 += 20;     //value1 + value1 20 = 30

            Console.WriteLine(" This result += is : {0}", value1);
            Console.WriteLine("-----------------------------------");

            int value2 = 100;
            value2 -= 120;     //value2 - value2 20 = 30

            Console.WriteLine(" This result -= is : {0}", value2);
             Console.WriteLine("-----------------------------------");


            int value3 = 90;
            value3 *= 5;     //value3 - value3 5 = 420

            Console.WriteLine(" This result *= is : {0}", value3);
            Console.WriteLine("-----------------------------------");

            int value4 = 100000;
            value4 += 20;     //value4 / value4 20 = 30

            Console.WriteLine(" This result /= is : {0}", value4);










            Console.ReadLine();











        }
    }     
    }

