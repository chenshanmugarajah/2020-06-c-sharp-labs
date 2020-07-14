using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsExercisesLib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var listOfIntegers = new List<int>();
            for (int i=1; i<=max; i++)
            {
                if (i % 5 == 0) listOfIntegers.Add(i);
            }
            return listOfIntegers;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            try
            {
                return argList.Average();
            } catch (Exception e)
            {
                return 0;
            }
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var eliteStrings = new List<string>();
            foreach(string s in sourceList)
            {
                if (s[0] == 'A' || s[0] == 'a') eliteStrings.Add(s);
            }
            return eliteStrings;
        }
    }
}