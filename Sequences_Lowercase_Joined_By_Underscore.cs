using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatch
{
    internal class Sequences_Lowercase_Joined_By_Underscore
    {
        public void Sequences_Lowercase_Joined_Underscore()
        {
            string input = "hello_world abc_def_123 x_y_z";
            string pattern = @"[a-z]+_[a-z]+";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
