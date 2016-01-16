using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.Sorting
{
  public class SelectionSort
  {
    public int[] Sort(int[] inputArr, bool isAscending = true)
    {
      int length = inputArr.Length;
      int[] retVal = new int[length];

      for (int i = 0; i < length; i++)
      {
        int min = i;
        for (int j = i + 1; j < length; j++)
        {
          if (inputArr[j] < inputArr[i])
            min = j;
        }

        if (min != i)
        {
          int temp = inputArr[min];
          inputArr[min] = inputArr[i];
          inputArr[i] = temp;
        }
      }

      inputArr.CopyTo(retVal, 0);
      if (!isAscending)
        return retVal.Reverse().ToArray();

      return retVal;
    }
  }
}
