using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAP_Week3_Exercise3_2_BalancedParantheses
{
    internal static class CheckBalancedParantheses
    {
        /// <summary>
        /// Static method for checking if there's a balanced number of parantheses in a string -
        /// that is are all opened parantheses closed again, and does the string only contain valid
        /// parantheses.
        /// Valid parantheses for this assignent are "[", "(" and "{" and the reversed versions.
        /// </summary>
        /// <param name="s">string to check</param>
        /// <returns>true if balanced, else false</returns>
        internal static bool Check(string s)
        {
            Stack<char> stack = new();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{') stack.Push(s[i]);
                else if (s[i] == ')')
                {
                    if (stack.Count > 0 && stack.Pop() == '(') continue;
                    else return false;
                }
                else if (s[i] == '}')
                {
                    if (stack.Count > 0 && stack.Pop() == '{') continue;
                    else return false;
                }
                else if (s[i] == ']')
                {
                    if (stack.Count > 0 && stack.Pop() == '[') continue;
                    else return false;
                }
                else return false;
            }
            if (stack.Count == 0) return true;
            return false;
        }

    }
}
