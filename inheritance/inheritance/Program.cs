using System.Runtime.CompilerServices;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //========Object Vehicle Class=========
            //Vehicle vehicle = new Vehicle();
            //vehicle.vModel = "Yaris";
            //vehicle.vYear = "2025";
            //vehicle.print();

            //========Object Toyota Class=========
            Toyota toyota = new Toyota();
            toyota.vModel = "Yaris";
            toyota.vYear = "2025 Latest";
            toyota.reviews = "5 stars";
            toyota.detailPrint();

            Console.WriteLine("-------------------------------------------------------------");
            //========Object Toyota Class=========
            Audi audi = new Audi();
            audi.vModel = "A4";
            audi.vYear = "2022";
            audi.luxury = "10 out of 10";
            audi.Detail();

        }
    }

    class Vehicle
    {
        public string vModel;
        public string vYear;


            //**********Method Vehicle Class***********
                //public void print()
        //{
        //    Console.WriteLine("model is {0} & Year {1}", this.vModel, this.vYear);
        //}
    }

    class Toyota : Vehicle
    {
        public string reviews;

        //**********Method Toyata Class***********
        public void detailPrint()
        {
            Console.WriteLine("model is {0} , manufacturing Year {1} & {2} rating...",
                this.vModel, this.vYear, this.reviews);
        }
    }

    //**********Method Audi Class***********
    class Audi : Vehicle
    {
        public string luxury;

        public void Detail()
        {
            Console.WriteLine("model is {0} , manufacturing Year {1} & {2} rating...",
                this.vModel, this.vYear, this.luxury);
        }

    }
}
