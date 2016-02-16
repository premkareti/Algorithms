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
using AlgosStudy.HackerEarth;
using AlgosStudy.TutorialHorizon;

namespace AlgosStudy
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine(Partition(new int[]{3,8,2,5,1,7,6}));
      Console.WriteLine(Partition(new int[] { 3 }));
      Console.WriteLine("Press any key to exit");
      Console.ReadKey();
    }

    private static int Partition(int[] val)
    {
      if (val.Length == 1)
        return 1;

      int i = 0, j;

      for (j = 1; j < val.Length; j++)
      {
        if (val[j] < val[0])
        {
          ++i;
          var temp = val[i];
          val[i] = val[j];
          val[j] = temp;
        }
      }

      var temp1 = val[0];
      val[0] = val[i];
      val[i] = temp1;

      return i;
    }

    private static int MySqrt(int x)
    {
      if (x < 0)
        return x;

      if (x == 0 || x == 1)
        return x;

      ulong num = 0;
      for (ulong i = (ulong)x / 2; i >= 1; i--)
      {
        num = i * i;
        if (num <= (ulong)x)
        {
          num = i;
          break;
        }
      }

      return (int)num;
    }

    private static int profit(int[] value, int length)
    {
      if (length <= 0)
        return 0;
      // either we will cut it or don't cut it
      int max = -1;
      for (int i = 0; i < length; i++)
        max = Math.Max(max, value[i] + profit(value, length - (i + 1)));
      return max;
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
