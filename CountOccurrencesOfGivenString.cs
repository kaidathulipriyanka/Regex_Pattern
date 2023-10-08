using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatch
{
    internal class CountOccurrencesOfGivenString
    {
        public void CountOccurrences_OfGivenString()
        {
            string pattern = @"fox(es)?";
            string input = "foxes are omnivorous mammals belonging to several genera of the family Canidae fox.";

            int count = Regex.Matches(input, pattern).Count;

            Console.WriteLine($"There are {count} occurrences.");
        }
    }
}
