using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy
{
  // Helper class for common utilities
  public class Utilities
  {
    public static long PowerOfNum(int baseNum, int power)
    {
      if (power == 0)
        return 1;

      var x = PowerOfNum(baseNum, (int)Math.Floor((decimal)power / 2));
      if (power % 2 == 0)
        return x * x;
      else
        return baseNum * x * x;
    }

    public static void SwapElementsAtIndexes(int[] inputArray, int index1, int index2)
    {
      if (index1 < inputArray.Length && index2 < inputArray.Length)
      {
        var temp = inputArray[index1];
        inputArray[index1] = inputArray[index2];
        inputArray[index2] = temp;
      }
    }
  }
}
