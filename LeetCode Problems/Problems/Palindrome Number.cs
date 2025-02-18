using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Problems
{
    public class PalindromeNumber : AlgorithmBase
    {
        public override void Run()
        {
            int number = 1234554321;
            bool result = Solve(number);
        }

        //Given an integer x, return true if x is a palindrome ,and false otherwise.

        //Example 1:

        //Input: x = 121
        //Output: true
        //Explanation: 121 reads as 121 from left to right and from right to left.
        //Example 2:

        //Input: x = -121
        //Output: false
        //Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
        //Example 3:

        //Input: x = 10
        //Output: false
        //Explanation: Reads 01 from right to left.Therefore it is not a palindrome.


        //Constraints:

        //-231 <= x <= 231 - 1



        //Follow up: Could you solve it without converting the integer to a string?

        public bool Solve(int x)
        {
            string numberString = x.ToString();
            int lenght = numberString.Length;

            for (int i = 0; i < lenght; i++)
            {
                if (numberString[i] != numberString[numberString.Length - i - 1])
                {
                    Console.WriteLine("False");
                    return false;
                }
            }

            Console.WriteLine("True");
            return true;
        }
    }
}
