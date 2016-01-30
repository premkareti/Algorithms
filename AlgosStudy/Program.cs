using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using AlgosStudy.Sorting;
using AlgosStudy.DataStructures;
using AlgosStudy.LeetCode;
using AlgosStudy.GeeksForGeeks;

namespace AlgosStudy
{
  class Program
  {
    static void Main(string[] args)
    {
      Tree temp = new Tree();
      var root = temp.CreateTree(new object[] { 10, 12, 13, null, null, 14, null });
      PrintAncestor t = new PrintAncestor();
      StringBuilder s = new StringBuilder();
      t.Display(root, 12, s);
      Console.WriteLine(s);

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
