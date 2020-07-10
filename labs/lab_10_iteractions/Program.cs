using System;
using System.Diagnostics.Tracing;

namespace lab_10_iteractions
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ans = 0;
            //for (int i=0; i<=100; i++)
            //{
            //    ans += i;
            //};

            //Console.WriteLine(ans);

            //string nish = "NISH IS KING";
            //foreach (char c in nish)
            //{
            //    Console.WriteLine((c.ToString()).ToLower());
            //}

            //int counter = 0;
            //while (counter < 10)
            //{
            //    counter++;
            //    Console.WriteLine(counter);
            //    if (counter < 4) continue;
            //    Console.WriteLine(counter * 10);

            //    //break is out of loop
            //    //continue is out of particular loop cycle
            //}

            for (int i=1; i<=20; i++)
            {
                Console.WriteLine(i);
                if (i % 15 == 0) break; 
            }
        }
    }
}
