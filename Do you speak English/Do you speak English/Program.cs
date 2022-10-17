// See https://aka.ms/new-console-template for more information


/*
 Given a string of arbitrary length with any ascii characters. 
Write a function to determine whether the string contains the whole word "English".

The order of characters is important -- a string "abcEnglishdef" is correct but "abcnEglishsef" is not correct.

Upper or lower case letter does not matter -- "eNglisH" is also correct.

Return value as boolean values, true for the string to contains "English", false for it does not.
*/

using System;
using System.Linq;
namespace Solution
{
    static class Kata
    {
        public static bool SpeakEnglish(string sentence)
        {

            return (sentence.ToLower().Contains("english")) ? true : false;
        }
    }
}
