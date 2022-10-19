/*
 *Complete the method which accepts an array of integers, and returns one of the following:

"yes, ascending" - if the numbers in the array are sorted in an ascending order
"yes, descending" - if the numbers in the array are sorted in a descending order
"no" - otherwise
 */

using System.Linq;
using System;
public class Kata
{
    public static string IsSortedAndHow(int[] array)
    {
        if (array.SequenceEqual(array.OrderBy(a => a))) return "yes, ascending";
        else if (array.SequenceEqual(array.OrderByDescending(a => a))) return "yes, descending";
        else return "no";
    }

}