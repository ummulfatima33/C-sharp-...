using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace selectionConstruct_nestedIf_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Example  

            int yrsOfService = 3;
            double salary = 1500;
            int bonus = 0;

            if (yrsOfService < 5)
            {
                if (salary > 500)
                {
                    bonus = 100;
                     }
                else {
                    bonus = 200;
                }
                   }
                else
                 {
                bonus = 700;
                      }

            Console.WriteLine("Bonus Amount : " + bonus);


                   //2nd EXAMPLE

            Console.WriteLine("-----------------------------------------------");


            int age = 16;
            string time = "evening";
            int ticketPrice = 0;

            if (age < 18)
            {
                if (time == "morning")
                {
                    ticketPrice = 100;
                }
                else
                {
                    ticketPrice = 150;
                }
            }
            else
            {
                ticketPrice = 200;
            }

            Console.WriteLine("Ticket Price: " + ticketPrice);

            Console.ReadKey();
             }
       }
}
