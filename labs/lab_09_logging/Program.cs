using System;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace lab_09_logging
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("Output.log", $"Printing i \n\n");

            #region loop with stopwatch

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i=0; i<10; i++)
            {
                Console.WriteLine(i);
                File.AppendAllText("Output.log", $"\nThe value of i is {i} at {DateTime.Now} ");
                Thread.Sleep(500);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine(stopwatch.ElapsedTicks);

            #endregion 

            //Interrogate our log file

            //1. Simple way as one string
            Console.WriteLine($"\n\nOutput As String\n\n");
            string outputFileString = File.ReadAllText("Output.log");
            string outputFileString2 = File.ReadAllText("../../../Output2.log");
            Console.WriteLine(outputFileString);

            //2. Each line pushed into array
            Console.WriteLine($"\n\nOutput As Array\n\n");
            string[] outputFileArray = File.ReadAllLines("Output.log");
            foreach (string line in outputFileArray)
            {
                Console.WriteLine(line);
            }
        }
    }
}
