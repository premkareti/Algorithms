using System.Collections.Generic;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/rotate-array/
   */
  public class RotateArray
  {
    public void Rotate(int[] nums, int k)
    {
      var len = nums.Length;
      var rem = k % len;
      if (len == k || rem == 0)
        return;

      List<int> temp = new List<int>();
      for (int i = 0; i < len - rem; i++)
      {
        temp.Add(nums[i]);
      }

      for (int i = 0; i < len; i++)
      {
        if (i < rem)
          nums[i] = nums[len - rem + i];
        else
          nums[i] = temp[i - rem];
      }
    }
  }
}
