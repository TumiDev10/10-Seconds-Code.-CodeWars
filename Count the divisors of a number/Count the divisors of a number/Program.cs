// See https://aka.ms/new-console-template for more information


/*
 Count the number of divisors of a positive integer n.

Random tests go up to n = 500000.

Note you should only return a number, the count of divisors. 
The numbers between parentheses are shown only for you to see which numbers are counted in each case.
*/

using System;
using System.Linq;
public class Kata
{
    public static int Divisors(int n)
    {
        // todo
        int numberOfDivisors = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                numberOfDivisors++;
        }
        return numberOfDivisors;

    }
}
