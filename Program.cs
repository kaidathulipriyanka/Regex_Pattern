
using System.Text.RegularExpressions;

namespace RegexPatternMatch
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            // Match a string with 'a' followed by two to three 'b'


            _a__followed_by_two_to_three__b_ match = new _a__followed_by_two_to_three__b_();
            match.a_Followed_By_2_Or_3_b();

            // Find sequences of lowercase letters joined by an underscore

            Sequences_Lowercase_Joined_By_Underscore join =new Sequences_Lowercase_Joined_By_Underscore();
            join.Sequences_Lowercase_Joined_Underscore();

            // Fetch all HTML tags from a given string

            FetchHTMLTags fetchHTMLTags = new FetchHTMLTags();
            fetchHTMLTags.FetchHTMLTagsFromString();

            // Count the number of occurrences of the pattern in a given string

            CountOccurrencesOfGivenString countOccurrencesOfGivenString = new CountOccurrencesOfGivenString();
            countOccurrencesOfGivenString.CountOccurrences_OfGivenString();

            // Find valid file names with an image file type extension 

            FindValidFileNames_With_Image_FileType find_name_Image= new FindValidFileNames_With_Image_FileType();
            find_name_Image.FindValidFileNames_With_Image_();

            // Validate a website address format 

            ValidateWebsiteAddressFormat validateWebsiteAddressFormat = new ValidateWebsiteAddressFormat();
            validateWebsiteAddressFormat.ValidateWebsite_AddressFormat();

        }
    }
}
