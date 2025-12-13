using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced
{
    internal static class StringUtilities
    {
        public static string ReverseString(this string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string CapitalizeAllWords(this string input)
        {
            var words = input.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    var word = words[i];
                    words[i] = char.ToUpper(word[0]) + word.Substring(1);
                }
            }
            return string.Join(" ", words);
        }
    }
}
