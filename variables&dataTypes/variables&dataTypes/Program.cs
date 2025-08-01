using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables_dataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Data Types!");
            string stdname = "Humza";
            int age = 20;
            bool status = false;
            double height = 5.5;
            //float height = 5.1F;


            Console.Write("Data Type Of " + stdname);
            Console.WriteLine(" " + stdname.GetType());

            Console.Write("Data Type Of " + age);
            Console.WriteLine(" " + age.GetType());

            Console.Write("Data Type Of " + status);
            Console.WriteLine(" " + status.GetType());

            Console.Write("Data Type Of " + height);
            Console.WriteLine(" " + height.GetType());

            Console.WriteLine("-------------------------------");
                  Console.WriteLine("Implicit!");

            var uname = "Kashan";
            Console.Write("Data type of " + uname);
            Console.WriteLine(" " + uname.GetType());

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Break Sequence!");
            Console.WriteLine("Ali is a \"good\" student");

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Placeholder!");
            Console.WriteLine("{0} is a student , age is {1} years old \n status is {2} & height is {3}" , stdname,age,status,height);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Type Conversion!");
            //Console.WriteLine("Your Age???");
            /*var myage = Console.ReadLine();
            Console.WriteLine(myage.GetType());*/

            Console.WriteLine("Enter Age???");
            //var yourage = int.Parse( Console.ReadLine());
            var yourage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(yourage.GetType());

            Console.ReadKey();


        }
    }
}
