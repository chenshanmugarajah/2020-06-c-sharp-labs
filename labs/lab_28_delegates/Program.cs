using Microsoft.VisualBasic.FileIO;
using System;

namespace lab_28_delegates
{
    class Program
    {
        delegate void Delegate01();

        delegate string Delegate02(int x, bool y);

        static void Main(string[] args)
        {
            Delegate01 myDelegateInstance = Method01;

            Action myOtherDelegateInstance = Method02;

            Delegate02 secondDelegate = Method03;

            myDelegateInstance();
            myOtherDelegateInstance();

            Console.WriteLine(secondDelegate(3, false)); 
        }

        static string Method03(int x, bool y)
        {
            string gender = y ? "male" : "female";

            return $"Age: {x} and Gender: {gender}";
        }

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
