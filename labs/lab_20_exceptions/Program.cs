using System;

namespace lab_20_exceptions
{
    public class Program
    {
        private static string[] _theBeatles = new string[] { "John", "Paul", "George", "Ringo" };

        public static void AddBeatle(int pos, string name)
        {
            //try
            //{
            //    _theBeatles[pos] = name;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("1. Sorry, no 5th Beatle Allowed");
            //    Console.WriteLine($"2. { e.ToString() }");
            //    Console.WriteLine($"3. { e.Data }");
            //    Console.WriteLine($"4. { e.Message }");
            //}
            //finally
            //{
            //    Console.WriteLine("Here comes the sun!");
            //}

            if (pos < 0 || pos >= _theBeatles.Length)
            {
                throw new ArgumentException($"The Beatles do not have a position {pos}");
            }
            _theBeatles[pos] = name;
        }

        static void Main(string[] args)
        {
            try
            {
                AddBeatle(4, "Brian");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            //int x = 10, y = 0;
            //try
            //{
            //    int output = x / y;

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception occured");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("But life goes on");
            //}


        }
    }
}
