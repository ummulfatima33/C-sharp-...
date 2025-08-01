using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your 1st value?");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your 2nd value?");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("This Result Is : " + (input1 + input2));
            Console.WriteLine("This Result Is : " + (input1 - input2));
            Console.WriteLine("This Result Is : " + (input1 * input2));
            Console.WriteLine("This Result Is : " + (input1 / input2));
            Console.WriteLine("This Result Is : " + (input1 % input2) + "%" );

            Console.ReadKey();


        }
    }
}
