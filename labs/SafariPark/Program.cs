using System;
using System.Collections.Generic;

namespace SafariPark
{
    public class Program
    {
        static void Main(string[] args)
        {

            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            Console.WriteLine(a.Move(3));
            Console.WriteLine(a);
            a.Descend(200);
            Console.WriteLine(a.Move());
            a.Move();
            Console.WriteLine(a);

        }
    }
}
