using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     //  jagged Array

                        //Method 1

            string[][] visitors = new string[3][];

            visitors[0] = new string[] { "Ali", "Umer", "Usman", "Haider" };    //length   3
            visitors[1] = new string[] { "Muntasha", "Kanzul" };                  //length  2
            visitors[2] = new string[] { "Fatima", "Warda", "Misbah", "Qudsia", "Fahmia" };    // length 5

            Console.WriteLine(" Name is " + visitors[0][3]);        
            Console.WriteLine(" Name is "  + visitors[1][1]);      
            Console.WriteLine(" Name is " + visitors[2][0]);       
            Console.WriteLine(" Name is " + visitors[2][4]);
            // Console.WriteLine(" Name is " + visitors[1][2]);        // Wrong Array Printing

            Console.WriteLine("---------------------------------");
            //Method 2

            string[][] users = new string[][]
            {
                new string [] {"Imran", "Humza", "Furqan"},
                new string [] {"Ali","Akbar"},
                new string []  {"Kashan","Faizan","Abdul Qadir"},
                new string[] {"Yawer","Ahtisham","Umer","Ahad"}
            };

            Console.WriteLine(users[1][1]);
            

            Console.ReadKey();
        }
    }
}
