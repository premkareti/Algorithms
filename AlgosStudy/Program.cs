using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgosStudy.Sorting;

namespace AlgosStudy
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] inputVals = new int[] { 7, 3, -1, 5, 6, 4, 0 };
      Console.WriteLine("Input Array: " + PrintArray(inputVals));
      InsertionSort insSort = new InsertionSort();
      Console.WriteLine("After Insertion Sort: " + PrintArray(insSort.Sort(inputVals)));
      SelectionSort selSort = new SelectionSort();
      Console.WriteLine("After Selection Sort: " + PrintArray(selSort.Sort(inputVals)));
      Console.WriteLine("Press any key to exit");
      Console.ReadKey();
    }

    private static string PrintArray(int[] inVals)
    {
      StringBuilder temp = new StringBuilder();
      foreach(var val in inVals)
      {
        temp.Append(val + " ");
      }
      return temp.ToString();
    }
  }
}
