using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy
{
  public class InsertionSort
  {
    public int[] Sort(int[] inputArr, bool isAscending = true)
    {
      int length = inputArr.Length;
      int[] retVal = new int[length];
      for (int i = 1; i < length; i++)
      {
        int j = i;
        while (j > 0 && inputArr[j] < inputArr[j - 1])
        {
          int k = inputArr[j];
          inputArr[j] = inputArr[j - 1];
          inputArr[j - 1] = k;
          j--;
        }
      }
      inputArr.CopyTo(retVal, 0);
      if (!isAscending)
        return retVal.Reverse().ToArray();

      return retVal;
    }
  }
}
