
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiDimensionalArray_rectangular_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------rectangular Array-------------");

            string[,] people = new string[2, 3];
            {
                people[0, 0] = "Fatima";
                people[0, 1] = "Obaid";
                people[0, 2] = "Mushtaq";


                people[1, 0] = "Ammara";
                people[1, 1] = "Warda";
                people[1, 2] = "Kanzul";


                //Console.WriteLine(people.Length);
                //Console.WriteLine(people[0,2]);
                //Console.WriteLine(people[1, 0]);
            }

            for (int i =0; i <= 1; i++)
            {
                Console.WriteLine("-----------------------");
                for(int j = 0; j <= 2; j++)
                {
                    Console.Write( j + ":  ");
                    Console.WriteLine(people[i, j]);
                }
            }
               
            Console.ReadKey();

        }
    }
}
