using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace lab_32_tasks
{
    class Program
    {
        static Stopwatch s = new Stopwatch();

        delegate void MyDelegate();

        static void Main(string[] args)
        {
            var thread01 = new Thread(() => { Thread.Sleep(3000); Console.WriteLine($"This thread01 is at {s.ElapsedMilliseconds}"); });
            var task01 = new Task(() => { Thread.Sleep(3000); Console.WriteLine($"This task01 is at {s.ElapsedMilliseconds}"); });
            var task02 = new Task(() => { Thread.Sleep(2000); Console.WriteLine($"This task02 is at {s.ElapsedMilliseconds}"); });

            var task04 = Task.Factory.StartNew(
                () => { Console.WriteLine("Hey I am running a task factory" ); }
                );

            s.Start();
            thread01.Start();
            task01.Start();
            task02.Start();
            Console.WriteLine($"The program has ended at {s.ElapsedMilliseconds}");
        }

        static void doThis()
        {
            Console.WriteLine("I am doing this");
        }
    }
}
