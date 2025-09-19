using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            //animal.sound();
            
            Goat goat = new Goat();
            goat.sound();
            goat.eat();

            Console.WriteLine("------------------------------");
             Fish fish = new Fish();    
            fish.sound();   
            fish.eat();

            //Console.WriteLine("------------------------------");
            //Car car = new Car();
            //car.Start();

            Console.WriteLine("------------------------------");
            Alto alto = new Alto();
            alto.Start();

            Console.WriteLine("------------------------------");
            Man billgates = new Man();
            billgates.Talk();
            billgates.Fly();

        }
    }
}
