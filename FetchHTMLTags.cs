using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatch
{
    internal class FetchHTMLTags
    {
        public void FetchHTMLTagsFromString() {

            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
            string pattern = @"<[^>]+>";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
