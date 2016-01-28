using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/reverse-bits/
   */
  public class ReverseBits
  {
    public uint reverseBits(uint n)
    {
      uint res = 0;
      int counter = 0;
      while (++counter <= 32)
      {
        var temp = n & 1;
        res = res * 2 + temp;
        n = n >> 1;        
      }

      return res;
    }
  }
}
