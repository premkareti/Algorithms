using System.Collections.Generic;
using System.Linq;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/contains-duplicate/
   */

  public class ContainsDup
  {
    public bool ContainsDuplicate(int[] nums)
    {
      if (nums.Length <= 1)
        return false;

      Dictionary<int, int> temp = new Dictionary<int, int>();

      foreach (var val in nums)
      {
        if (temp.ContainsKey(val))
          temp[val]++;
        else
          temp.Add(val, 1);
      }

      return temp.Any(kv => kv.Value > 1);
    }
  }
}
