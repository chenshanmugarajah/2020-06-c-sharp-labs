using System;

namespace PhilPowerTests
{
    public class Powers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static double RaiseToPower(double x, double y, int p)
        {
            return Math.Pow((x * y), p);
        }
    }
}
