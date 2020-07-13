using System;

namespace lab_13_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //tuple
            Console.WriteLine(TripleCalc(1, 2, 4));

            //out
            int sum = 0;
            Console.WriteLine(sum);
            Console.WriteLine(TripleCalc(1, 2, 4, out sum));
        }

        public static int  TripleCalc (int a, int b, int c, out int sum)
        {
            sum = a + b + c; // sets sum to 7
            return a * b * c; // returns 8
        }

        public static (int sum, int product) TripleCalc (int a, int b, int c)
        {
            return (a + b + c, a * b * c); // returns (7 , 8)
        }

        //public static int DoThisPartTWo (int  x, string y, out bool z)
        //{
        //    Console.WriteLine(y);
        //    z = (x > 10);
        //    return x * x;
        //}

        //public static (int xsquared, bool y_more_10) DoThat (int x, string y)
        //{
        //    Console.WriteLine(y);
        //    var z = (x > 10);
        //    return (x*x, z);
        //}

        //static void OrderPizza (bool pepperoni, bool pineapple, bool banana = false)
        //{
        //    if (pepperoni && pineapple && banana)
        //    {
        //        Console.WriteLine("Delicious");
        //    }
        //    if (pepperoni && !pineapple && banana)
        //    {
        //        Console.WriteLine("Wheres the pineapple?");
        //    }
        //    if (!pepperoni && !pineapple && !banana)
        //    {
        //        Console.WriteLine("Idiots messed up!");
        //    }
        //    if (pepperoni && pineapple && !banana)
        //    {
        //        Console.WriteLine("Wheres my BANANA!");
        //    }
        //    else
        //    {
        //        Console.WriteLine(":(");
        //    }
        //}

        //public static void DoThis()
        //{
        //    Console.WriteLine("WE ARE SPARTA!");
        //}

        //public static string DoThisStr()
        //{
        //    return "We Are Sparta";
        //}
    }
}
