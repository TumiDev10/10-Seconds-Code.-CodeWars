// See https://aka.ms/new-console-template for more information


/*
 Create a function that converts US dollars (USD) to Chinese Yuan (CNY) . The input is the amount of USD as an integer, 
and the output should be a string that states the amount of Yuan followed by 'Chinese Yuan'

Examples (Input -> Output)

The conversion rate you should use is 6.75 CNY for every 1 USD. All numbers should be represented as a string with 2 decimal places. 
(e.g. "21.00" NOT "21.0" or "21")
*/

public static class Kata
{
    public static string Usdcny(int usd)
    {
        decimal cny = 6.75m;
        decimal result = usd * cny;
        return ($"{result} Chinese Yuan");
    }
}
