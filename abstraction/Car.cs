using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    abstract class Car
   {
        public abstract void startengine();
        public void Start()
        {
            Console.WriteLine("Car is Starting...");
            startengine();
        }
    }

    class Alto : Car
    {
        public override void startengine()
        {
            Console.WriteLine("engine is start when you push the key");
        }
    }
}
