using System;
using System.Collections.Generic;

namespace SafariPark
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Hunter Bryn = new Hunter("Bryn", "Morley", "Sony") { Age = 25 };
            //Console.WriteLine(Bryn.ToString());

            Person p1 = new Person("Nish", "Mandal");
            Hunter h1 = new Hunter("Hunter", "Mate");
            MonsterHunter mh1 = new MonsterHunter("Monster", "Lad", "Nikon", "Love");

            var safariList = new List<Object>();
            safariList.Add(p1);
            safariList.Add(h1);
            safariList.Add(mh1);

            foreach(var item in safariList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
