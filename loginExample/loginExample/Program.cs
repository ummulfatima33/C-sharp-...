using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "admin";
            int password = 1234;

            Console.Write("Enter Your Username?");
            string inputname = Console.ReadLine();

            Console.Write("Enter Your password ?");
            int inputpassword = Convert.ToInt16 (Console.ReadLine());

            Console.WriteLine("-------------------------------------");

            if(inputname == username & inputpassword == password)
            {
                Console.WriteLine("Login successfully");
            }
            else
            {
                Console.WriteLine("Invalid Credentials");
            }

            Console.ReadKey();

            


        }
    }
}
