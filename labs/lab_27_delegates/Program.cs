using System;

namespace lab_27_delegates
{
    class Program
    {
        delegate void myDelegate01();

        static void Main(string[] args)
        {
            // Delegates

            // 1. Placeholder from one or more methods
            // 2. Can use anonymous lambda expressions, very useful particularly with async web calls
            // 3. Link to events --> EVENT FIRES EG BUTTON CLICK --> All methods must match pattern given in our delegate
            // void myDelegate01() 

            // GOAL 
            // create events --> run given methods
            // 1. create delegate at the top

            // 2. create delegate instance
            var delegateInstance = new myDelegate01(Method01);

            // 3. run the delete instance
            delegateInstance();
        }

        // Theses are Action methods
        // no input and no output
        static void Method01()
        {
            Console.WriteLine("I am method 01");
        }

        static void Method02()
        {
            Console.WriteLine("I am method 02");
        }
    }
}
