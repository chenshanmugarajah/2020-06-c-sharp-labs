using System;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class CollectionsExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string peopleInQ = "";

            for (int i=0; i<num; i++)
            {
                if (queue.Count == 0) break; 
                if (i != 0) peopleInQ += ", ";
                peopleInQ += queue.Peek();
                queue.Dequeue();
            }

            return peopleInQ;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            var reverseStack = new Stack<int>();

            for (int i=0; i<original.Length; i++)
            {
                reverseStack.Push(original[i]);
            }

            return reverseStack.ToArray();
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            var occurances = new Dictionary<string, int>();
            string[] inputArray = input.Split("");

            foreach(char s in input)
            {
                try
                {
                    int x = Int32.Parse(s.ToString());
                    if (occurances.ContainsKey(s.ToString()))
                    {
                        occurances[s.ToString()] += 1;
                    }
                    else
                    {
                        occurances.Add(s.ToString(), 1);
                    }
                } catch (Exception e)
                {
                }
            }

            string output = "";

            foreach(var item in occurances)
            {
                output += $"[{item.Key}, {item.Value}]";
            }

            return output;
        }
    }
}