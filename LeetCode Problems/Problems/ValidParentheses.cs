using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode_Problems.Problems
{
    public class ValidParentheses : AlgorithmBase
    {
        public override void Run()
        {
            //string paramethers = "{}}{";
            string paramethers = "()";
            bool result = Solve(paramethers);
            Console.WriteLine(result);
        }

        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        //An input string is valid if:

        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.
        //Every close bracket has a corresponding open bracket of the same type.


        //Example 1:

        //Input: s = "()"

        //Output: true

        //Example 2:

        //Input: s = "()[]{}"

        //Output: true

        //Example 3:

        //Input: s = "(]"

        //Output: false

        //Example 4:

        //Input: s = "([])"

        //Output: true




        //Constraints:

        //1 <= s.length <= 104
        //s consists of parentheses only '()[]{}'.

        public bool Solve(string s)
        {
            while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return s.Length == 0;
        }
    }
}
