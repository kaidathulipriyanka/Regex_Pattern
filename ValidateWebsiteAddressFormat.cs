using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPatternMatch
{
    internal class ValidateWebsiteAddressFormat
    {
        public void ValidateWebsite_AddressFormat()
        {
            string input = "https://www.example.com http://invalid.com www.google.com";
            string pattern = @"^(https?://)?(www\.)?\w+\.\w{2,3}$";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value + " is a valid website address.");
            }
        }
    }
}
