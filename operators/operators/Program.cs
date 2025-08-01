using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = 50;
            int value2 = 15;
            int value3 = 50;

            Console.WriteLine("------------------------Arithmetic-------------------------------");
          
            Console.WriteLine("The result of addition is : " + (value1 + value2));
            Console.WriteLine("The result of subtraction is : " + (value1 - value2));
            Console.WriteLine("The result of multiplication is : " + (value1 * value2));
            Console.WriteLine("The result of division is : " + (value1 / value2));
            Console.WriteLine("The result of modules is : " + (value1 % value2));

           
            Console.WriteLine("-----------------------Relational-------------------------------");
            Console.WriteLine("The result == is : " + (value1 == value2));
            Console.WriteLine("The result != is : " + (value1 != value2));
            Console.WriteLine("The result > is : " + (value1 > value2));
            Console.WriteLine("The result < is : " + (value1 < value2));
            Console.WriteLine("The result == is : " + (value1 == value3));
            Console.WriteLine("The result >= is : " + (value1 >= value2));
            Console.WriteLine("The result >= is : " + (value2 >= value1));
            Console.WriteLine("The result <= is : " + (value1 <= value2));


            Console.WriteLine("-----------------------Logical-------------------------------");

            Console.WriteLine("--And--");
            Console.WriteLine((value1 > value2) & (value1 == value2) & (value1 != value2));
            Console.WriteLine((value1 > value2) & (value1 == value3) & (value1 != value2));
            Console.WriteLine((value1 == value2) & (value1 < value3) & (value1 != value3));
            Console.WriteLine((value1 > value2) & (value1 == value3) & (value1 > value2));

            Console.WriteLine("--OR--");

            Console.WriteLine((value1 > value2) | (value1 == value3) | (value1 != value2));
            Console.WriteLine((value1 == value2) | (value1 != value3) | (value1 < value2));
            Console.WriteLine((value1 > value2) | (value1 == value2));
            Console.WriteLine((value1 > value2) | (value1 > value2));



            Console.ReadKey();

        }
    }
}
