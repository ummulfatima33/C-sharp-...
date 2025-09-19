using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    abstract class Animal
    {
        //public void sound()
        //{
        //    Console.WriteLine("Animal Here");
        //}
        public abstract void sound();
        public abstract void eat();
    }

    class Goat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("mai mai");
        }

        public override void eat()
        {
            Console.WriteLine("Goat eat grass");
        }
    }
    class Fish : Animal
    {
        public override void sound()
        {
            Console.WriteLine("no sound");
        }

        public override void eat()
        {
            Console.WriteLine("Fish eat meat");
        }
    }
}