using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using AlgosStudy.Sorting;
using AlgosStudy.DataStructures;

namespace AlgosStudy
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> tempArr = new List<int>();
      Random rand = new Random();
      int j = 0;
      while (++j < 10000000)
      {
        tempArr.Add(rand.Next(Int32.MinValue, Int32.MaxValue));
      }

      var inputVals = tempArr.ToArray();
      //Console.WriteLine("Input Array: " + PrintArray(inputVals));

      Stopwatch watch = new Stopwatch();
      watch.Start();
      QuickSort sort = new QuickSort();
      sort.Sort(inputVals);
      watch.Stop();
      Console.WriteLine("Time taken for my quicksort is: " + watch.Elapsed.TotalSeconds + " seconds");

      watch.Restart();
      Array.Sort(inputVals);
      watch.Stop();
      Console.WriteLine("Time taken for .NET default sort is: " + watch.Elapsed.TotalSeconds + " seconds");

      Console.WriteLine("Press any key to exit");
      Console.ReadKey();
    }

    private static string PrintArray(int[] inVals)
    {
      StringBuilder temp = new StringBuilder();
      foreach (var val in inVals)
      {
        temp.Append(val + " ");
      }
      return temp.ToString();
    }
  }
}
