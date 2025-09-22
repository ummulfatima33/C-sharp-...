using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Non Generic Colletions
            var list = new ArrayList();
           
            list.Add("Faizan");
            list.Add(26);
            list.Add("5.5");
            list.Add("Raza");
            list.Add(3);
            list.Add(false);
            list.Add(2);
            Console.WriteLine(list[0]);

            Console.WriteLine("------------------------------------");

            
             //Insert Method
            list.Insert(1, "Majid Sheikh");
            Console.WriteLine(list[1]);

            // 2 values multiplication
            int num1 = (int)list[5];   // 3
            int num2 = (int)list[7];   // 2
            Console.WriteLine(num1 * num2);

            Console.WriteLine("------------------------------------");


              //Remove Method
            //list.Remove("5.5");
            //list.Remove(3);
            list.Remove("Raza");
            foreach (var item in list) {
             Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------");

            
            //RemoveAt Method

            list.RemoveAt(4);
            foreach (var outup in list)
            {
                Console.WriteLine(outup);
            }

            Console.WriteLine("------------------------------------");

            //Contains Method
            Console.WriteLine(list.Contains("Faizan"));
            Console.WriteLine(list.Contains("Kinza"));

            Console.WriteLine("------------------------------------");

            //IndexOf Method
            Console.WriteLine(list.IndexOf("Faizan"));
            Console.WriteLine(list.IndexOf("5.5"));

            Console.WriteLine("------------------------------------");

            //Sort  & Reverse Method

            var marks = new ArrayList();

            marks.Add(100);
            marks.Add(99);
            marks.Add(87);
            marks.Add(89);
            marks.Add(94);
            marks.Add(110);
            marks.Add(72);
            marks.Add(80);
            //marks.Sort();
            marks.Reverse();    

            foreach (var stdmarks in marks)
            {
                Console.WriteLine(stdmarks);
            }
        }
    }
}
