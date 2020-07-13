using System;
using System.Collections;
using System.Collections.Generic;

namespace lab_21_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myQ = new Queue<string>();

            //myQ.Enqueue("First time");
            //myQ.Enqueue("Second item");
            //myQ.Enqueue("Middle item");
            //myQ.Enqueue("Last item");

            //myQ.Dequeue();

            //Console.WriteLine(myQ.Peek());

            //var myS = new Stack<string>();
            //myS.Push("First item");
            //myS.Push("Second item");
            //myS.Push("Third item");
            //myS.Push("Last item");

            //Console.WriteLine(myS.Peek());

            //var personDict = new Dictionary<int, string>(); //key value pair

            //personDict.Add(1, "Nish");
            //personDict.Add(2, "Phil");
            //personDict.Add(3, "Cathy");

            //foreach (var person in personDict)
            //{
            //    Console.WriteLine(person.Value);
            //};

            string input = "We are Sparta";
            input = input.Trim().ToLower();

            var countDictionary = new Dictionary<char, int>();

            foreach(var c in input)
            {
                if (countDictionary.ContainsKey(c))
                {
                    countDictionary[c]++;
                }
                else
                {
                    countDictionary.Add(c, 1);
                }
            }

            foreach(var entry in countDictionary)
            {
                Console.WriteLine(entry);
            }

        }
    }
}
