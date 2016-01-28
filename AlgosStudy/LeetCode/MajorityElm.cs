using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/majority-element/
   */
  public class MajorityElm
  {
    public int MajorityElement(int[] nums)
    {
      var len = nums.Length;
      if (len == 1 || len == 2)
        return nums[0];

      Dictionary<int, int> temp = new Dictionary<int, int>();
      int n = 0;
      foreach (var val in nums)
      {
        if (temp.ContainsKey(val))
          temp[val]++;
        else
          temp.Add(val, 1);

        if (temp[val] > Math.Floor((double)len / 2))
        {
          n = val;
          break;
        }
      }

      return n;
    }
  }
}
