using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace classes_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students std1 = new Students();   // Object Class 1
            std1.id = 3;
            std1.name = "Khadija";
            std1.age = 15;
            std1.address = "Karachi";
            std1.course = "Python";

            std1.Details();

            Console.WriteLine("----------------------------------------------------------------------------------------");
            Students std2 = new Students();
            std2.id = 4;
            std2.name = "fatima";
            std2.age = 18;
            std2.address = "Malir";
            std2.course = ".Net Core";

            std2.Details();

            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Students std3 = new Students();
            std3.id = 5;
            std3.name = "Amna";
            std3.age = 17;
            std3.address = "Saddar";
            std3.course = "AI/ML";

            std3.Details();

            Console.WriteLine("-----------------------------------------------------------------------------------------");


            // Object Class 2




            //Vehicle veh1 = new Vehicle();

            /*
            Vehicle veh1 = new Vehicle();
            veh1.setDetails("Toyota", "yaris");
            veh1.getDetails();

            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Vehicle veh2 = new Vehicle();
            veh2.setDetails("Honda", "Civic");
            veh2.getDetails();  */

            Vehicle veh5 = new Vehicle("Toyota", "Land Crouser");
            Console.WriteLine("-----------------------------------------------");


            Vehicle veh6 = new Vehicle("Honda", "Grandee");
            Console.WriteLine("-------------------------------------------------");

         
            Vehicle veh7 = new Vehicle("Toyota", "Coaster");
            Console.WriteLine("------------------------------------------------");


            Console.ReadKey();

        }
    }


    class Students  //     Class
    {
        //Properties
        public int id;
        public string name;
        public int age;
        public string address;
        public string course;


        //Method Without Parameter
        public void Details()
        {
            Console.WriteLine("Student Id {0}, Name is {1}, Age is {2}, Address {3} & Enroll {4}",
                this.id, this.name, this.age, this.address, this.course);
        }
    }

    class Vehicle
    {
        public string company;
        public string model;


        //public void setDetails(string companyName, string modelName)
        //{
        //    this.company = companyName;
        //    this.model = modelName;
        //}

        //public void getDetails()
        //{
        //    Console.WriteLine("{1} is a very fast because company is {0}",
        //     this.company, this.model);
        //}




        //**************Constructor Without Parameter**********

        //public Vehicle()
        //{
        //    Console.WriteLine("main automatically chlta hun........");



        //**************Constructor With Parameter**********
        public Vehicle(string companyName, string modelName)
        {
            this.company = companyName;
            this.model = modelName;

            Console.WriteLine("{1} is a very fast because company is {0}",
            this.company, this.model);
        }
    }
}


