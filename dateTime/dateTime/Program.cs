using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("DateTime.");
            Console.WriteLine("---------------------");
            var today =  DateTime.Now;
            Console.WriteLine("Date&Time is : {0:G}", today);
            Console.WriteLine("Time is : {0:t}" , today);
            Console.WriteLine("Time is : {0:T}", today);
            Console.WriteLine("Year is : {0:Y}", today);
            Console.WriteLine("Year is : {0:y}", today);
            Console.WriteLine("Month is : {0:m}", today);
            Console.WriteLine("Day is : {0:ddd}", today);
            Console.WriteLine("Day is : {0:dddd}", today);


            Console.WriteLine("---------------------");
            Console.WriteLine("Statement.");
            string myname = "Yawar";
            Console.WriteLine(myname);

            
            Console.WriteLine("---------------------");
            Console.WriteLine("Expression.");
            var calculation = 2 + 10;
            Console.WriteLine(calculation);












            Console.ReadKey();



        }
    }
}
