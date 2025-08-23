namespace multiLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Cat mycat = new Cat();
            mycat.name = "Twinkle";
            mycat.sound = "Meon Meon";
            mycat.colour = "White";
            mycat.Details();

        }
    }


    class Animal
    {
        public string name;
        public string sound;
       }


     class Mammals : Animal
    {
      
    }

    class Cat : Mammals
    {
        public string colour;
        public void Details()
        {
            Console.WriteLine("Cat name is {0}, Sound {1} & colour is {2}...",
                this.name, this.sound, this.colour);
        }


    }


}
