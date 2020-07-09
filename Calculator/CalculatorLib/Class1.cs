using System;
using System.Net;

namespace CalculatorLib
{
    public class StaticCalculator
    {
        public static double add (double i, double k)
        {
            return i + k;
        }

        public static double subtract (double i, double k)
        {
            return i - k;
        }

        public static double multiply (double i, double k)
        {
            return i * k;
        }

        public static double divide (double i, double k)
        {
            return i / k;
        }

        public static double modulus (double i, double k)
        {
            return i % k;
        }
    }
}
