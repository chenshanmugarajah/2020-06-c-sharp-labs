using System;
using System.IO.Pipes;
using IterationLib;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop
            int ans = nums[0];
            int pointer = 0;
            while (pointer < nums.Length)
            {
                if (nums[pointer] > ans)
                {
                    ans = nums[pointer];
                }
                pointer++;
            }
            return ans;
        }

        public static int HighestForLoop(int[] nums)
        {
            int ans = nums[0];
            for (int i=0; i<nums.Length; i++)
            {
                if (nums[i] > ans)
                {
                    ans = nums[i];
                }
            }
            return ans;
        }

        public static int HighestForEachLoop(int[] nums)
        {
            int ans = nums[0];
            foreach (int i in nums)
            {
                if (i > ans)
                {
                    ans = i;
                }
            }
            return ans;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            int ans = nums[0];
            int pointer = 0;
            do
            {
                if (nums[pointer] > ans)
                {
                    ans = nums[pointer];
                }
                pointer++;
            } while (pointer < nums.Length);

            return ans;
        }
    }
}