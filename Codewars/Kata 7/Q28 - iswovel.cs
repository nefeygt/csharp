/*

Check if it is a vowel(a, e, i, o, u,) on the n position in a string (the first argument). Don't forget about uppercase.

A few cases:

{
checkVowel('cat', 1)  ->   true // 'a' is a vowel
checkVowel('cat', 0)  ->   false // 'c' is not a vowel
checkVowel('cat', 4)  ->   false // this position doesn't exist
}
P.S. If n < 0, return false

*/


no c# was present but I solved it in c# myself

using System;

public class Vowel
{
  public static bool CheckVowel(string s, int n)
  {
    if (n < 0 || n >= s.Length)
    {
      return false;
    }

    char ch = char.ToLower(s[n]);
    return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
  }
}