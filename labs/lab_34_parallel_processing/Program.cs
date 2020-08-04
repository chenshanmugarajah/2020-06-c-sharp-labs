using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace lab_34_parallel_processing
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => { OvernightTask01(); },
                () => { OvernightTask02(); },
                () => { OvernightTask03(); },
                () => { OvernightTask04(); },
                () => { OvernightTask05(); }
            );

            var s = new Stopwatch();
            s.Start();

            var taskArray = new Task[32];
            for (int i = 0; i < taskArray.Length; i++)
            {
                var j = i;
                taskArray[i] = Task.Run(() => { Console.WriteLine($"Task {j} has completed at {s.ElapsedMilliseconds}"); });
            }

            Console.WriteLine($"All completed at {s.ElapsedMilliseconds}");

            //Console.ReadLine();

            Parallel.For(0, 10,
                i =>
                {
                    Thread.Sleep(7);
                    Console.WriteLine($"Parallel for job {i} - running in background");
                });

            var stringArray = new string[] { "Hey", "there", "I", "am", "string", "array" };
            Parallel.ForEach(stringArray,
                (item) =>
                {
                    Console.WriteLine($"Processing the item: {item} with the length {item.Length}");
                });

            Console.ReadLine();

            var customers = new List<string>();
        }

        static void OvernightTask01() { Console.WriteLine("Processing overnight task 01"); }
        static void OvernightTask02() { Console.WriteLine("Processing overnight task 02"); }
        static void OvernightTask03() { /*Thread.Sleep(500); */ Console.WriteLine("Processing overnight task 03"); }
        static void OvernightTask04() { Console.WriteLine("Processing overnight task 04"); }
        static void OvernightTask05() { Console.WriteLine("Processing overnight task 05"); }

    }
}
