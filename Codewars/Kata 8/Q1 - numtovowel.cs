/*

Given an array of numbers, check if any of the numbers are the character codes for lower case vowels (a, e, i, o, u).

If they are, change the array value to a string of that vowel.

input [100,100,116,105,117,121]=>[100,100,116,"i","u",121] output Return the resulting array.

*/

using System;
using System.Linq;

public class Kata
{
    public static object[] IsVow(int[] a)
    {
      object[] result = new object[a.Length];
      char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

      for (int i = 0; i < a.Length; i++) 
      {
        char currentChar = (char)a[i];

        if (vowels.Contains(currentChar)) 
        {
          result[i] = currentChar.ToString();
        }
        else
        {
          result[i] = a[i];
        }
      }

      return result;
    }
}