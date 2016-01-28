using System;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/reverse-integer/
   */
  public class ReverseInt
  {
    public int Reverse(int x)
    {
      if (x == Int32.MinValue)
        return 0;
      bool isNeg = false;
      if (x < 0)
      {
        x = x * -1;
        isNeg = true;
      }
      int rem = 0;
      int res = 0;
      long total = 0;
      while ((res = Math.DivRem(x, 10, out rem)) != 0)
      {
        total = total * 10 + rem;
        if (isNeg)
        {
          if (total * -1 < Int32.MinValue)
            return 0;
        }
        else
        {
          if (total > Int32.MaxValue)
            return 0;
        }
        x = res;
      }

      if (rem != 0)
      {
        total = total * 10 + rem;
        if (isNeg)
        {
          if (total * -1 < Int32.MinValue)
            return 0;
        }
        else
        {
          if (total > Int32.MaxValue)
            return 0;
        }
      }

      if (isNeg)
        return (int)total * -1;
      else
        return
          (int)total;
    }
  }
}
