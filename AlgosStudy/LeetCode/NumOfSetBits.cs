using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/number-of-1-bits/
   */
  public class NumOfSetBits
  {
    public int HammingWeight(uint n)
    {
      if (n == 0)
        return 0;
      int i = 1;
      var k = n & (n - 1);
      while (k != 0)
      {
        i++;
        k = k & (k - 1);
      }
      return i;
    }
  }
}
