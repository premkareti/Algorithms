using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.Sorting
{
  public class MergeSort
  {
    public int[] Sort(int[] inputArr, bool isAscending = true)
    {
      int[] retVal = new int[inputArr.Length];

      inputArr.CopyTo(retVal, 0);
      Divide(retVal, 0, retVal.Length - 1);

      if (!isAscending)
        return retVal.Reverse().ToArray();

      return retVal;
    }

    private void Divide(int[] inArr, int low, int high)
    {
      int middle;
      if (low < high)
      {
        middle = (low + high) / 2;
        Divide(inArr, low, middle);
        Divide(inArr, middle + 1, high);
        Merge(inArr, low, middle, high);
      }
    }

    private void Merge(int[] inArr, int low, int middle, int high)
    {
      Queue<int> buff1 = new Queue<int>();
      Queue<int> buff2 = new Queue<int>();

      for (int i = low; i <= middle; i++)
        buff1.Enqueue(inArr[i]);

      for (int j = middle + 1; j <= high; j++)
        buff2.Enqueue(inArr[j]);

      int k = low - 1;
      while(buff1.Count != 0 && buff2.Count != 0)
      {
        k++;
        var temp1 = buff1.Peek();
        var temp2 = buff2.Peek();

        if(temp1 < temp2)
        {
          inArr[k] = temp1;
          buff1.Dequeue();
        }
        else
        {
          inArr[k] = temp2;
          buff2.Dequeue();
        }        
      }

      while(buff1.Count != 0)
      {
        k++;
        inArr[k] = buff1.Dequeue();
      }

      while (buff2.Count != 0)
      {
        k++;
        inArr[k] = buff2.Dequeue();
      }      
    }
  }
}
