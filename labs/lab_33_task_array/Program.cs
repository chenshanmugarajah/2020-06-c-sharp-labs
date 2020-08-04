using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace lab_33_task_array
{
    class Program
    {
        static Stopwatch s = new Stopwatch();
        static void Main(string[] args)
        {
            // Single tasks - not much benefit
            // Array of tasks - each one can complete at its own leisure

            s.Start();

            var taskArray = new Task[5];

            taskArray[0] = Task.Run(() => { Console.WriteLine($"Task 0 completed"); });
            taskArray[1] = Task.Run(() => { Console.WriteLine($"Task 1 completed"); });
            taskArray[2] = Task.Run(() => { Console.WriteLine($"Task 2 completed"); });
            taskArray[3] = Task.Run(() => { Thread.Sleep(500); Console.WriteLine($"Task 3 completed"); });
            taskArray[4] = Task.Run(() => { Thread.Sleep(300); Console.WriteLine($"Task 4 completed"); });

            // Get data back from Task.Result
            var getDataBack = Task<string>.Run(() => { return "Here is some data back from my background task"; } );

            // Wait for specific task to be completed
            var taskOne = Task.Run(() => { Thread.Sleep(800); Console.WriteLine("Individual task completed"); });

            // Wait for any one task to be completed
            Task.WaitAny(taskArray);
            Console.WriteLine($"First task completed at {s.ElapsedMilliseconds}");

            // Wait for all tasks to be completed
            Task.WaitAll(taskArray);
            Console.WriteLine($"All tasks completed at {s.ElapsedMilliseconds}");

            taskOne.Wait();
            Console.WriteLine($"Singular task completed at {s.ElapsedMilliseconds}");

            Console.WriteLine($"Background data function completed at {s.ElapsedMilliseconds } with the data " + getDataBack.Result);

            Console.ReadLine();
        }
    }
}
