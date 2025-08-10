using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FOR LOOP

            //for(int i = 0; i < 10; i++)        //  0 --9
            //for (int i = 0; i <= 20; i++)        //  0 --20
            //{
            //    Console.WriteLine(i);
            //}


            //FOR LOOP WITH TABLE
            //Console.WriteLine("========TABLE WITH LOOP==========");
            //int table = 3;
            //for(int a = 1; a <= 10; a++)
            //{
            //    Console.WriteLine(table + " x " + a + " = " + table * a);
            //}

            // while LOOP

            int b = 1;
            while (b > 10)
            {
                Console.WriteLine("Number  : " + b);   //  1 - 9
                b++;
            }


            Console.WriteLine("------------------------------");
            // DO while LOOP

            int c = 1;

            do
            {
                Console.WriteLine("Number  : " + c);
                c++;
            } while (c < 1);
           
                    Console.ReadKey();
        }
    }
}
