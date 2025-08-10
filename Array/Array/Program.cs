using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================SINGLE DIMENSIONAL ARRAY====================");
            //  Method 1
            string[] students = new string[13];
            students[0] = "Mustafa";
            students[1] = "Ahmed";
            students[2] = "Fatima";
            students[3] = "Ali";
            students[4] = "Humza";
            students[5] = "Faizan";
            students[6] = "Majid";
            students[7] = "Haider";
            students[8] = "Sana";
            students[9] = "Ubaid";
            students[10] = "Mushtaq";
            students[11] = "Asim";
            students[12] = "Umer Asim";

            //students[12] = 2;      //wrong data type
            //students[8] = "Sir Rizwan";    //Over Ride possible in Array

            //Console.WriteLine(students[8]);
            //Console.WriteLine(students[12]);

            Console.WriteLine("---------------------------------------------");

            int[] marks = new int[3];

            marks[0] = 96;
            marks[1] = 70;
            marks[2] = 87;

            //marks[1] = 99;

            Console.WriteLine(marks[1]);

            Console.WriteLine("---------------------------------------------");

            //Method 2


            string[] users = { "Ali", "Umer", "Abu Bakar", "Usman", "" };     //Length 3

            //users[4] = "Fatima";   //Length 4

            Console.WriteLine(users[4]);

            //foreach LOOP

            foreach (string std in students)
            {
                if (std == "Ubaid")
                {
                    //continue;
                    break;
                }
                

                Console.WriteLine(std);
            }



           



            Console.ReadKey();
        }
    }
}
