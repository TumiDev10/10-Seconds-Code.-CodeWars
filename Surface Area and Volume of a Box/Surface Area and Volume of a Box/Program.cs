// See https://aka.ms/new-console-template for more information

/*
 Write a function that returns the total surface area and volume of a box as an array: [area, volume]
*/

using System;

public class Kata
{
    public static int[] Get_size(int w, int h, int d)
    {
        //Your code

        int area = 2 * (w * h + h * d + w * d);
        int volume = w * h * d;
        return new int[] { area, volume };
    }
}
