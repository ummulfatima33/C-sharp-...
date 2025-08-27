using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Animal
    {
        virtual public void Sound()
        {
            Console.WriteLine( "Animal Sound");
        }
    }

    class Cat : Animal
    {
       override public void Sound()
        {
            Console.WriteLine("Meaon Meaon");
        }
    }
    class Dog : Animal
    {
      override  public void Sound()
        {
            Console.WriteLine("Baooo Baooo");
        }
    }


          //********sealed Classes*******
    //sealed class A
    //{
    //    public string Name = "Class A";
    //}

    //class B : A
    //{
    //    public string name = "Class B";
    //}

}
