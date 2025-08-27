namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Compile Time Polymorphism Objects
            Calculator mycalculator = new Calculator();
            mycalculator.Calculate(12, 3);
            mycalculator.Calculate(2, 1.5f, 2);
            mycalculator.Calculate("Fatima", "Shahid", "Attari");
            mycalculator.Calculate(5.5f, 1.5f, 0.2f);


            //Compile Time Polymorphism Objects
             Cat mycat = new Cat();
             mycat.Sound();

            Dog mydog = new Dog();
            mydog.Sound();

           

        }


        //Compile Time Polymorphism

        class Calculator
        {
            public void Calculate(int a , int b)
            {
                Console.WriteLine( a + b);
            }

            public void Calculate(int a, float b, int c)
            {
                Console.WriteLine(a - b * c);
            }

            public void Calculate(string a, string b, string c)
            {
                Console.WriteLine(a + " " + " " + b + " " + c);
            }

            public void Calculate(float a, float b, float c)
            {
                Console.WriteLine(a * b % c);
            }
        }

    }
}
