﻿using System;

namespace lab_03_dot_net_core_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World from a programmer");
            int[] myArray = { 1, 2, 3, 4, 5 };
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }


        }
    }
}
