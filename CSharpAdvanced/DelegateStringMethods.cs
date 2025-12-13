using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced
{
    internal class DelegateStringMethods
    {
        public void UppercaseString(string input)
        {
            string uppercaseString = input.ToUpper();
            Console.WriteLine("Uppercase: " + uppercaseString);
        }

        public void ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed: " + reversedString);
        }

        public void ReplaceSpacesWithHyphens(string input)
        {
            string hyphenedString = input.Replace(" ", "-");
            Console.WriteLine("Hyphened: " + hyphenedString);
        }
    }
}
