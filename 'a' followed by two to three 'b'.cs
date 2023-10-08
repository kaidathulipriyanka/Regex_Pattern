using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatch
{
    internal class _a__followed_by_two_to_three__b_
    {
        public void a_Followed_By_2_Or_3_b()
        {
            string input = "abb abbb aabbb abbbb abbbbba";
            string pattern = @"ab{2,3}";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
