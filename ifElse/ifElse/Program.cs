using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              bool request = true;
              string mode = "good";

            if (request)
            {
                if (mode == "bad")
                {
                    Console.WriteLine("Mode is Awesomeeeeee");
                }
                else
                {
                    Console.WriteLine("Mode is Average");
                }
            }


            else
            {
                if (mode == "good")
                {
                    Console.WriteLine("Mode is  moreee  Awesome");
                }
                else
                {
                    Console.WriteLine("Mode is bad");
                }
            }
            */


            Console.WriteLine("---------------------Switch Case---------------------");

            var favFood = "Pullao";

            switch (favFood) {

                case "Karahi":
                    Console.WriteLine("Karahi is my Fav Food");
                    break;

                case "Biryani":
                    Console.WriteLine("Biryani is my Fav Food");
                    break;

                case "Nihari":
                    Console.WriteLine("Nihari is my Fav Food");
                    break;

                case "BBQ":
                    Console.WriteLine("BBQ is my Fav Food");
                    break;

                case "Pizza":
                    Console.WriteLine("Pizza is my Fav Food");
                    break;

                case "Pasta":
                    Console.WriteLine("Pasta is my Fav Food");
                    break;

                case "Fish":
                    Console.WriteLine("Fish is my Fav Food");
                    break;

                case "Zinger":
                    Console.WriteLine("Zinger is my Fav Food");
                    break;

                default:
                    Console.WriteLine("All food is my Fav Food");
                    break;




            }














            Console.ReadKey();
                  }
                }
              }
