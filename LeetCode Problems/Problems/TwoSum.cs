using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode_Problems.Problems
{
    public class TwoSum : AlgorithmBase
    {
        public override void Run()
        {
            int[] nums = { 1, 3, 4, 8, 12, 15 };
            int target = 11;
            int[] result = Solve(nums, target);
            Console.WriteLine($"Sonuç: [{result[0]}, {result[1]}]");
        }

        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //You can return the answer in any order.

        //Example 1:

        //Input: nums = [2, 7, 11, 15], target = 9
        //Output: [0,1]
        //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        //Example 2:

        //Input: nums = [3, 2, 4], target = 6
        //Output: [1,2]
        //Example 3:

        //Input: nums = [3, 3], target = 6
        //Output: [0,1]

        //Constraints:

        //2 <= nums.length <= 104
        //-109 <= nums[i] <= 109
        //-109 <= target <= 109
        //Only one valid answer exists.

        public int[] Solve(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int number1 = nums[i];

                for (int j = i + 1; j < nums.Length; j++)
                {
                    int number2 = nums[j];

                    if (number1 + number2 == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }
    }
}
