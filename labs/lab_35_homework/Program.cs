using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace lab_35_homework
{
    class Program
    {

        static Stopwatch s = new Stopwatch();
        static List<string> output = new List<string>();
        static List<string> streamReaderAsyncOutput = new List<string>();

        static void Main(string[] args)
        {
            s.Start();
            CreateFileWithLines(1000);
            Console.WriteLine($"Create file with lines completed at {s.ElapsedMilliseconds} ms");

            s.Restart();
            FileReadLinesToArray();
            Console.WriteLine($"Read files with file reader completed at {s.ElapsedMilliseconds} ms");

            s.Restart();
            FileReadLinesToListAsync();
            Console.WriteLine($"Read files to list with async file reader completed at {s.ElapsedMilliseconds} ms");

            s.Restart();
            _ = FileReadLinesToTaskListAsync();
            Console.WriteLine($"Read files to task list with async file reader completed at {s.ElapsedMilliseconds} ms");

            s.Restart();
            StreamFileReadAsync();
            Console.WriteLine($"Read files async stream read lines completed at {s.ElapsedMilliseconds} ms");

        }

        static void CreateFileWithLines(int amountOfLines)
        {
            if (File.Exists("data.txt")) { File.Delete("data.txt"); }
            if (!File.Exists("data.txt"))
            {
                for (int i = 0; i < amountOfLines; i++)
                {
                    File.AppendAllText("data.txt", $"Adding line to file\n");
                }
            }
        }
        static string[] FileReadLinesToArray()
        {
            return File.ReadAllLines("data.txt");
        }
        static async void FileReadLinesToListAsync()
        {
            var array = await File.ReadAllLinesAsync("data.txt");
            output = array.ToList();
        }
        static async Task<string[]> FileReadLinesToTaskListAsync()
        {
            return await File.ReadAllLinesAsync("data.txt");
        }
        static async void StreamFileReadAsync()
        {
            using (var reader = new StreamReader("data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    streamReaderAsyncOutput.Add(await reader.ReadLineAsync());
                }
            }
        }
    }
}
