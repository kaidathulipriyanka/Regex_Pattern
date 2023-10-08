using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;  

namespace RegexPatternMatch
{
    internal class FindValidFileNames_With_Image_FileType
    {
        public void FindValidFileNames_With_Image_()
        {
            string input = "image1.jpg file.txt image2.png script.js";
            string pattern = @"\b\w+\.(jpg|png|gif|bmp)\b";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
