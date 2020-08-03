using System;

namespace lab_29_delegate_with_lambda
{
    class Program
    {

        delegate string MyDelegate(string x, int y);

        static void Main(string[] args)
        {
            MyDelegate instance01 = MyMethod;

            Console.WriteLine(instance01("fred", 12));

            //lambda alternative
            MyDelegate instance02 = (x, y) =>
            {
                return $"Thanks {x} you have entered {y} ";
            };

            Console.WriteLine(instance02("bob", 33));
        }

        static string MyMethod(string x, int y)
        {
            return $"Thanks {x} you have entered {y} ";
        }
    }
}
