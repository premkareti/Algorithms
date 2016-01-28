using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using AlgosStudy.Sorting;
using AlgosStudy.DataStructures;
using AlgosStudy.LeetCode;

namespace AlgosStudy
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = new int[] { 1,2 };
      RotateArray temp = new RotateArray();
      temp.Rotate(arr, 3);
      Console.WriteLine(PrintArray(arr));
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
