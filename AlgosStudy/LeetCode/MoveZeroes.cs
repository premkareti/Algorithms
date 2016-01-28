using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/move-zeroes/
   */

  public class MoveZeroes
  {
    public void MoveZeros(int[] nums)
    {
      int copyIndex = 0;
      var len = nums.Length;
      for (int i = 0; i < len; i++)
      {
        if (nums[i] != 0)
        {
          nums[copyIndex++] = nums[i];
        }
      }

      for (int i = copyIndex; i < len; i++)
        nums[i] = 0;
    }
  }
}
