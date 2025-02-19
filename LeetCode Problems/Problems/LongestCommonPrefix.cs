using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode_Problems.Problems
{
    public class LongestCommonPrefix : AlgorithmBase
    {
        public override void Run()
        {
            string[] strings = ["flower", "flowlight", "flight"];
            string result = Solve(strings);
            Console.WriteLine(result);
        }

        //Write a function to find the longest common prefix string amongst an array of strings.

        //If there is no common prefix, return an empty string "".




        //Example 1:

        //Input: strs = ["flower", "flow", "flight"]
        //Output: "fl"
        //Example 2:

        //Input: strs = ["dog", "racecar", "car"]
        //Output: ""
        //Explanation: There is no common prefix among the input strings.


        //Constraints:

        //1 <= strs.length <= 200
        //0 <= strs[i].length <= 200
        //strs[i] consists of only lowercase English letters if it is non-empty.

        public string Solve(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            StringBuilder result = new StringBuilder();
            string firstWord = strs[0];

            for (int i = 0; i < firstWord.Length; i++)
            {
                char onMemoryChar = firstWord[i];

                foreach (string str in strs)
                {
                    if (i >= str.Length || str[i] != onMemoryChar)
                    {
                        return result.ToString();
                    }
                }

                result.Append(onMemoryChar);
            }

            return result.ToString();
        }
    }
}
