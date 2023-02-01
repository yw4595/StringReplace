using System;

namespace StringReplace
{
    /// <summary>
    /// Author: Yanzhi Wang
    /// Purpose: The purpose of this class is to demonstrate how to replace "no" with "yes" in a string in a case-insensitive manner.
    /// Restrictions: None
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            /// <summary>
            /// Purpose: The purpose of this method is to replace all occurrences of the word "no" with "yes" in a case-insensitive manner.
            /// Restrictions: None
            /// </summary>
            string pattern = @"\bno\b";
            string replacement = "yes";
            string result = System.Text.RegularExpressions.Regex.Replace(input, pattern, replacement, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            Console.WriteLine("Result: " + result);
        }
    }
}
