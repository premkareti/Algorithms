using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/string-to-integer-atoi/
   */
  public class AtoI
  {
    public int MyAtoi(string str)
    {
      str = str.Trim();
      if (String.IsNullOrEmpty(str))
        return 0;

      bool isNegNum = false;
      int i = 0;

      if (str[0] == '-')
      {
        isNegNum = true;
        i = 1;
      }
      else if (str[0] == '+')
      {
        i = 1;
      }

      long result = 0;
      while (i < str.Length &&
            ((int)str[i] >= 48 && (int)str[i] <= 57))
      {
        var val = Convert.ToInt64(str[i]) - 48;
        if (isNegNum)
        {
          if ((result * 10 + val) * -1 < (long)Int32.MinValue)
            return Int32.MinValue;
        }
        else
        {
          if ((result * 10 + val) > (long)Int32.MaxValue)
            return Int32.MaxValue;
        }

        result = (result * 10) + val;
        i++;
      }

      if (isNegNum)
        return ((int)result * -1);
      else
        return (int)result;
    }
  }
}
