using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //************* List Class*********

            //1st  List STRING
            List<string> students = new List <string>();
            students.Add("Fatima");
            students.Add("Faizan");
            students.Add("Obiad");
            students.Insert(1, "Amna");
            Console.WriteLine(students[1]);      //call with index Number

            Console.WriteLine("----------------------------------");

            //students.Sort();
            //students.Reverse();
            //students.RemoveAt(3);
            //students.Contains("Obiad");
            foreach (var std in students)
            {
                Console.WriteLine(std);
            }


            Console.WriteLine("----------------------------------");

              //2nd List INT
            List<int> studentMarks = new List<int>();
            studentMarks.Add(111);
            studentMarks.Add(63);
            studentMarks.Add(2);
            studentMarks.Add(40);
            studentMarks.Add(76);
            studentMarks.Sort();
            Console.WriteLine(studentMarks[1]);
          

            Console.WriteLine("----------------------------------");

            foreach (var marks in studentMarks)
            {
                Console.WriteLine(marks);
            }
            Console.WriteLine("----------------------------------");

            //************* Dictionary Class*********
            //===============================
            Dictionary<string,uint> contactList = new Dictionary<string,uint>();
            contactList.Add("Faizan", 03246789123);
            contactList.Add("Wania", 0324121278);
            contactList.Add("Anusha", 03125454065);
            contactList.Add("Ammara", 03246789456);

            Console.WriteLine(contactList["Anusha"]);

            Console.WriteLine(contactList["Ammara"]);

            Console.WriteLine("----------------------------------");

            //=============================================

            Dictionary<int, string> newDictionary = new Dictionary<int, string>();
            newDictionary.Add(1, "Amna");
            newDictionary.Add(2, "Khadija");
            newDictionary.Add(3, "Ayesha");
            newDictionary.Add(4,"Fatima");

            Console.WriteLine(3);

            Console.WriteLine("----------------------------------");

            //************* Stack (LIFO) Class*********

            Stack<string> colors = new Stack<string>();
            colors.Push("red");
            colors.Push("yellow");
            colors.Push("blue");

            foreach(var color in colors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("----------------------------------");

                      colors.Pop();
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("----------------------------------");

            //************* Queue (FIFO) Class*********

            Queue<string> bankQueue = new Queue<string>();
            bankQueue.Enqueue("Mustafa");
            bankQueue.Enqueue("Ali");
            bankQueue.Enqueue("Aliyan");

            foreach (var bankQueues in bankQueue)
            {
                Console.WriteLine(bankQueues);
            }

            Console.WriteLine("----------------------------------");


            //bankQueue.Dequeue();
            bankQueue.Clear();
            foreach (var bankQueues in bankQueue)
            {
                Console.WriteLine(bankQueues);
            }
        }

    }
}
