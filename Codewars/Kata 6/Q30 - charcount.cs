/*

The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.

What if the string is empty? Then the result should be empty object literal, {}.

*/

using System.Collections.Generic;
using System;

using System.Collections.Generic;
using System;
using System.Linq;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    return str.Aggregate(new Dictionary<char, int>(), (acc, cur) => 
    {
        if (acc.ContainsKey(cur))
            acc[cur]++;
        else
            acc[cur] = 1;
        
        return acc;
    });
  }
}