// See https://aka.ms/new-console-template for more information

/*
 Complete the function that takes two integers (a, b, where a < b)
and return an array of all integers between the input parameters, including them.
*/

using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static int[] Between(int a, int b)
    {
        // your code here
        var result = new List<int>();
        for (var i = a; i <= b; i++)
        {
            result.Add(i);
        }
        return result.ToArray();
    }
}


