using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.Sorting
{
  public class QuickSort
  {
    public void Sort(int[] inputArr)
    {
      Quick_Sort(inputArr, 0, inputArr.Length - 1);
    }

    private void Quick_Sort(int[] inputArr, int low, int high)
    {
      if (low < high)
      {
        var pivot = Partition(inputArr, low, high);
        Quick_Sort(inputArr, low, pivot - 1);
        Quick_Sort(inputArr, pivot + 1, high);
      }
    }

    private int Partition(int[] inputArr, int low, int high)
    {
      int i = low - 1;
      int j = low - 1;
      int pivot = high;
      while (++j < pivot)
      {
        if (inputArr[j] < inputArr[pivot])
        {
          ++i;
          Utilities.SwapElementsAtIndexes(inputArr, i, j);
        }
      }

      Utilities.SwapElementsAtIndexes(inputArr, pivot, i + 1);
      pivot = i + 1;

      return pivot;
    }
  }
}
