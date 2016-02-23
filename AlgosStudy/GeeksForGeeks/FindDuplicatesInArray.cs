using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.GeeksForGeeks
{
  public class FindDuplicatesInArray
  {
    public void printRepeating(int[] arr)
    {
      int size = arr.Length;
      int i;

      Console.WriteLine("The repeating elements are: ");

      for (i = 0; i < size; i++)
      {
        if (arr[Math.Abs(arr[i])] > 0)
          arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
        else
          Console.WriteLine(Math.Abs(arr[i]));
      }
    }
  }
}
