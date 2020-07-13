using System;

namespace lab_12_operators_and_junit
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 1;
            //int y = x++;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int a = 1;
            //int b = ++a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //find average of 2 5 1 8
            //var average = (2 + 5 + 1 + 8) / 4;
            //Console.WriteLine(average);

            //var a = 5 / 2;
            //var b = 5.0 / 2;
            //var c = 5 / 3;

            //// 26 days displayed in weeks and days;
            //var days = 26 % 7;
            //var weeks = 26 / 7;

            //Console.WriteLine($"Weeks: {weeks} and Days: {days}");

            // & checks both sides always
            // && checks one side at a time - short circuit

            // bitwise operators
            //int x = 3;
            //int y = 2;
            //x = +y;

            int a = 5, b = 3, c = 4;
            c += +a++ + ++b;

        }
    }
}
