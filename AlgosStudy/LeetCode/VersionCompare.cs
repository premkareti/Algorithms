using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/compare-version-numbers/
   */

  public class VersionCompare
  {
    public int compareVersion(string version1, string version2)
    {
      var v1 = version1.Split('.');
      var v2 = version2.Split('.');

      for (int i = 0; i < Math.Min(v1.Length, v2.Length); i++)
      {
        var v1num = Convert.ToInt32(v1[i]);
        var v2num = Convert.ToInt32(v2[i]);

        if (v1num < v2num)
          return -1;
        else if (v1num > v2num)
          return 1;
      }

      if (v1.Length == v2.Length)
        return 0;

      if (v1.Length > v2.Length)
      {
        for (int i = v2.Length; i < v1.Length; i++)
        {
          if (Convert.ToInt32(v1[i]) > 0)
            return 1;
        }
        return 0;
      }
      else
      {
        for (int i = v1.Length; i < v2.Length; i++)
        {
          if (Convert.ToInt32(v2[i]) > 0)
            return -1;
        }
        return 0;
      }
    }
  }
}
