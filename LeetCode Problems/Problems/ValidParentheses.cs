using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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

        //public bool Solve(string s)
        //{
        //    if (string.IsNullOrEmpty(s) || s.Length < 2) return false;

        //    bool isPairFound = false;

        //    string startOfBracket1 = "(";
        //    string pairOfBracket1 = ")";

        //    string startOfBracket2 = "[";
        //    string pairOfBracket2 = "]";

        //    string startOfBracket3 = "{";
        //    string pairOfBracket3 = "}";

        //    for (int i = 0; i < s.Length - 1; i++)
        //    {
        //        char onMemoryChar = s[i];
        //        char lastPairChar = s[s.Length - i - 1];

        //        if (onMemoryChar == startOfBracket1[0])
        //        {
        //            if (s[i + 1] == pairOfBracket1[0] || lastPairChar == pairOfBracket1[0])
        //            {
        //                isPairFound = true;
        //            }
        //        }

        //        if (onMemoryChar == startOfBracket2[0])
        //        {
        //            if (s[i + 1] == pairOfBracket2[0] || lastPairChar == pairOfBracket2[0])
        //            {
        //                isPairFound = true;
        //            }
        //        }

        //        if (onMemoryChar == startOfBracket3[0])
        //        {
        //            if (s[i + 1] == pairOfBracket3[0] || lastPairChar == pairOfBracket3[0])
        //            {
        //                isPairFound = true;
        //            }
        //        }

        //        isPairFound = false;
        //    }

        //    if (isPairFound == false)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        public bool Solve(string s)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> pairs = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

            foreach (char c in s)
            {
                
                if (pairs.ContainsKey(c))
                {
                    
                    if (stack.Count == 0 || stack.Pop() != pairs[c])
                    {
                        return false;
                    }
                }
                else
                {
                    
                    stack.Push(c);
                }
            }

            
            return stack.Count == 0;
        }
    }
}
