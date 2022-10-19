/*
 All Star Code Challenge #18

Create a function that accepts 2 string arguments and returns an integer 
of the count of occurrences the 2nd argument is found in the first one.

If no occurrences can be found, a count of 0 should be returned.
 */

class Kata
{
    public static int StrCount(string str, string letter)
    {
        //Do Some Magic
        int count = 0;
        foreach (char c in str)
        {
            if (c.ToString() == letter) count++;
        }
        return count;
    }
}