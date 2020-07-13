using System;
using System.Net.Security;

namespace lab_19_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tps = TimeSpan.TicksPerSecond;
            //var nowInTicks = DateTime.Now.Ticks;

            //Console.WriteLine(tps);
            //Console.WriteLine(nowInTicks);

            //var d = new DateTime();
            //var d1 = DateTime.Today;

            //var d2 = DateTime.Now;

            //Console.WriteLine(d);
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            //var d3 = new DateTime(2020, 7, 13, 10, 5, 18);

            //Console.WriteLine(d3);

            //d = d.AddDays(1);
            //d = d.AddMonths(1);

            //var nishBday = new DateTime(1989, 11, 02);
            //var age = DateTime.Now - nishBday;
            //int age2 = (int)(age.Days / 365.25);
            //Console.WriteLine(age2);

            //var date = DateTime.Now.ToString("dd-MM-yyyy");
            //var date2 = nishBday.ToString("yy/MMM/dd");
            //Console.WriteLine(date);
            //Console.WriteLine(date2);

            //var timespan = new TimeSpan(1, 0, 0);
            //var date = DateTime.Now + timespan;
            //var tick = new TimeSpan(1);
            //date = date + tick;

            //Suit theSuit = Suit.HEARTS;

            //switch(theSuit)
            //{
            //    case (Suit.HEARTS):
            //        Console.WriteLine("Heart");
            //        break;
            //    case (Suit.SPADES):
            //        Console.WriteLine("Spade");
            //        break;
            //    case (Suit.DIAMONDS):
            //        Console.WriteLine("Diamonds");
            //        break;
            //    case (Suit.CLUBS):
            //        Console.WriteLine("Clubs");
            //        break;
            //}

            //int x = 1;
            //int dog;
            //float cat;
            //bool thing;
            //char c;
            //DateTime aDate;
            //string aString;
            //int[] arr;

            //bool? hasPassed;
            //uint? numberOFTrainees;

            //int totalCost = 0;
            //int? item = 3;
            //if(item)
            //{
            //    Console.WriteLine();
            //}

            var rng = new Random();
            var rngSeeded = new Random(42);
            var between1and10 = rngSeeded.Next(1, 11);

            Console.WriteLine(between1and10);


        }

        public enum Suit
        {
            HEARTS,
            CLUBS,
            DIAMONDS,
            SPADES
        }
    }
}
