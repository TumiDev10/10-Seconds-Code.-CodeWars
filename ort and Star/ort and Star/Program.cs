// See https://aka.ms/new-console-template for more information

/*
 You will be given a list of strings. You must sort it alphabetically (case-sensitive, 
and based on the ASCII values of the chars) and then return the first value.

The returned value must be a string, and have "***" between each of its letters.

You should not remove or add elements from/to the array.
*/
using System;

public class Kata
{
    public static string TwoSort(string[] s)
    {
        Array.Sort(s, StringComparer.Ordinal);
        char[] a = s[0].ToCharArray();
        return String.Join("***", a);

    }
}