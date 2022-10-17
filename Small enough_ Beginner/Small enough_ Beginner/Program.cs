// See https://aka.ms/new-console-template for more information

/*
 You will be given an array and a limit value. You must check that all values in the array are below or equal to the limit value. 
If they are, return true. Else, return false.

You can assume all values in the array are numbers.
*/


using System;
using System.Linq;

public class Kata
{
    public static bool SmallEnough(int[] a, int limit)
    {
        return (a.Max() <= limit) ? true : false;
    }
}