using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/nim-game/ 
   */
  public class NimGame
  {
    public bool CanWinNim(int n)
    {
      return (n & 3) != 0;
    }
  }
}
