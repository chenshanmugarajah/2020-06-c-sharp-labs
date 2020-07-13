using System;
using System.Net;
using System.Threading;

namespace PhilLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu ()
        {
            Console.WriteLine($"\nWhich program would you like to run?");
            Console.WriteLine("Simple 0-300 loop which displays number....ENTER 1");
            Console.WriteLine("Loop w/ custom output every 100th number...ENTER 2");
            Console.WriteLine("Loop w/ custom output 5th, 105th 205th.....ENTER 3");
            Console.WriteLine("Loop that counts from 50 to 0..............ENTER 4");
            Console.WriteLine("PRESS 0 TO EXIT");
            Console.Write("Enter choice: ");
            string input = Console.ReadLine();
            Console.WriteLine($"\nSELECTED {input}");
            Console.WriteLine($"Starting...\n");
            Thread.Sleep(2000);
            try
            {
                handleInput(Int32.Parse(input));
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nError");
                Console.WriteLine("Please enter a number between 1 and 4");
                menu();
            }
        }

        static void handleInput (int input)
        {
            switch (input)
            {
                case 1: loop1();
                    break;
                case 2: loop2();
                    break;
                case 3: loop3();
                    break;
                case 4: loop4();
                    break;
                case 0: Console.WriteLine("Exiting..");
                    break;
                default: Console.WriteLine("Invalid input");
                    menu();
                    break;
            }
        }

        static void loop1 ()
        {
            for (int i=0; i<=300; i++)
            {
                Console.WriteLine(i);
            }

            menu();
        }

        static void loop2 ()
        {
            Console.Write("Enter custom message: ");
            string usersString = Console.ReadLine();
            for (int i=0; i<=300; i++)
            {
                if (i % 100 == 0) Console.WriteLine(usersString);
                else Console.WriteLine(i);
            }

            menu();
        }

        static void loop3 ()
        {
            Console.Write("Enter custom message: ");
            string usersString = Console.ReadLine();
            int pointer = 5;
            for (int i = 0; i <= 300; i++)
            {
                if (i == pointer)
                {
                    pointer += 100;
                    Console.WriteLine(usersString);
                }
                else Console.WriteLine(i);
            }

            menu();
        }

        static void loop4 ()
        {
            for (int i=50; i>=0; i--)
            {
                Console.WriteLine(i);
            }

            menu();
        }
    }
}
