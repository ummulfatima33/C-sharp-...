using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Human
    {
    }
        //Declare Interfaces
    interface IHuman
    {
         void Talk();
    }

    interface IAlien
    {
         void Fly();
    }
          //End Interface
    class Man : IHuman , IAlien
    {
        public void Talk()
        {
            Console.WriteLine("Human is Talking");
        }

        public void Fly()
        {
            Console.WriteLine("Human will be fly in future");
        }
    }
}
