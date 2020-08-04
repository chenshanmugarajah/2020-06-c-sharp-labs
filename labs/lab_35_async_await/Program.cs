using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xceed.Document.NET;

namespace lab_35_async_await
{
    class Program
    {
        static Stopwatch s = new Stopwatch();
        static List<string> fileOutput = new List<string>();
        static List<string> streamReaderAsyncOutput = new List<string>();

        static void Main(string[] args)
        {
            // async convention
            // async void DoThisSync () { code here }

            s.Start();

            // Creating files
            if (File.Exists("data.txt")) { File.Delete("data.txt"); }
            if (!File.Exists("data.txt"))
            {
                for (int i = 0; i < 2000; i++)
                {
                    File.AppendAllText("data.txt", $"Adding line to file\n");
                }
            }
            Console.WriteLine($"File create took {s.ElapsedMilliseconds} milliseconds");


            // File reader 
            s.Restart();
            var array01 = ReadTextFileToArray();
            Console.WriteLine($"File reader completed after {s.ElapsedMilliseconds} milliseconds");

            // Async file reader V2
            s.Restart();
            ReadTextFileToArrayAsync2();
            Console.WriteLine($"Async V2 File reader completed after {s.ElapsedMilliseconds} milliseconds with {fileOutput.Count} files");
            Thread.Sleep(3000);
            Console.WriteLine(fileOutput.Count + " files");

            // Stream reader not async
            s.Restart();
            var outputFromFile = new List<string>();
            using (var reader = new StreamReader("data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    outputFromFile.Add(reader.ReadLine());
                }
            }
            Console.WriteLine($"StreamReader took {s.ElapsedMilliseconds} milliseconds");

            s.Restart();
            StreamReadTextFileAsync();
            Console.WriteLine($"StreamReader Async took {s.ElapsedMilliseconds} milliseconds with {streamReaderAsyncOutput.Count} files");
            Thread.Sleep(3000);



            // Async file reader V1
            s.Restart();
            Task<string[]> array02 = ReadTextFileToArrayAsync();
            Console.WriteLine($"\nAsync V1 File reader completed after {s.ElapsedMilliseconds} milliseconds with {array02.Result.Length} records");

        }

        static async Task<string[]> ReadTextFileToArrayAsync()
        {
            return await File.ReadAllLinesAsync("data.txt");
        }


        static async void StreamReadTextFileAsync()
        {
            using (var reader = new StreamReader("data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    streamReaderAsyncOutput.Add(await reader.ReadLineAsync());
                }
            }
        }

        static string[] ReadTextFileToArray()
        {
            return File.ReadAllLines("data.txt");
        }

        static async void ReadTextFileToArrayAsync2()
        {
            var array = await File.ReadAllLinesAsync("data.txt");

            fileOutput = array.ToList();
        }

    }
}
