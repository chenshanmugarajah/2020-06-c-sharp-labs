using System;

namespace IterationLib
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //ignore
        }
    }

    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            if (nums.Length == 0) return int.MaxValue;
            int ans = nums[0];
            for (int i=0; i<nums.Length; i++)
            {
                if (nums[i] <= ans)
                {
                    ans = nums[i];
                }
            }
            return ans;
        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int ans = 0;
            for (int i=0; i<=max; i++)
            {
                if (i%2==0 || i%5==0)
                {
                    ans += i;
                }
            }
            return ans;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;

            foreach(char c in input.ToLower())
            {
                switch (c)
                {
                    case 'a': aCount++; break;
                    case 'b': bCount++; break;
                    case 'c': cCount++; break;
                    case 'd': dCount++; break;
                    default: break;
                }
            }

            return $"A:{aCount} B:{bCount} C:{cCount} D:{dCount}";
        }
    }
}