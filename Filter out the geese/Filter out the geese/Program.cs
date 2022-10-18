/*
 Write a function that takes a list of strings as an argument and 
returns a filtered list containing the same elements but with the 'geese' removed.
*/

using System.Collections.Generic;
using System.Linq;
using System;

public static class Filter
{
    public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
    {
        // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
        string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

        return birds.Except(geese);
    }
}