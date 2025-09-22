using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****Simple Class Objects**********

            /* Box mybox = new Box();
             int result = mybox.SetSize(5);
            Console.WriteLine("Box size " + result);*/

            //int result = mybox.SetSize("five"); y nh ho skta
            //int result = mybox.SetSize(5.5); y nh ho skta

            //****Simple Class Objects****

            Box<int> box1 = new Box<int>();
            int output1 = box1.SetSize(50);
            Console.WriteLine("Box size " + output1);

            Console.WriteLine("---------------------------");

            Box<double> box2 = new Box<double>();
            double output2 = box2.SetSize(5.7);
            Console.WriteLine("Box size " + output2);

            Console.WriteLine("---------------------------");

            Box<string> box3 = new Box<string>();
            string output3 = box3.SetSize("Five INTO Six");
            Console.WriteLine("Box size " + output3);

            Console.WriteLine("---------------------------");


        }
    }
           //Simple Class Objects

         /*class Box
    {
        public int boxSize;

        public int SetSize(int size)
        {
            this.boxSize = size;
            return boxSize;
        }
    } */


    //Generic Class

    class Box<T>
    {
        public T boxSize;

        public T SetSize(T size)
        {
            this.boxSize = size;
            return boxSize;
        }
    }

}
