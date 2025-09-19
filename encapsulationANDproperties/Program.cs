using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationANDproperties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //*** FIELDS Objects Start ***
            //Student std = new Student();
            //std.name = "Faizan";
            //std.age = 12;

            //Console.WriteLine(std.name);
            //Console.WriteLine(std.age);

            Student std1 = new Student();
            std1.setDetails("Faizan", 26);
            //std1.getDetail();
            //*** Properties Objects End ***

            Console.WriteLine("-------------------------------");
            //*** Properties Objects Start ***
            Properties prop1 = new Properties();
            prop1.name = "Ali";
            Console.WriteLine(prop1.name);

            Console.WriteLine("-------------------------------");
            Properties myprop = new Properties();
            myprop.age = 26;
            Console.WriteLine(myprop.age);

            Console.WriteLine("-------------------------------");
            Properties myprop2 = new Properties();
            //myprop2.mobile = "021****567788";   //ye nh ho skta
            Console.WriteLine(myprop2.mobile);

            Console.WriteLine("-------------------------------");
            Properties myprop3 = new Properties();
            myprop3.bankBalance = 26000;
            Console.WriteLine(myprop.bankBalance);    //ye nh ho skta
            //*** Properties Objects End ***
        }
    }
}
