/*
 Given a string made up of letters a, b, and/or c, switch the position of letters a and b 
(change a to b and vice versa). Leave any incidence of c untouched.

Example:

'acb' --> 'bca'
'aabacbaa' --> 'bbabcabb'
 */

using System;
using System.Linq;
public class Kata
{
    public static string Switcheroo(string x)
    {
        var letter = x.ToCharArray();
        for (int i = 0; i < x.Length; i++)
        {
            if (letter[i] == 'a')
                letter[i] = 'b';
            else if (letter[i] == 'b')
                letter[i] = 'a';
        }
        return new string(letter);
    }
}