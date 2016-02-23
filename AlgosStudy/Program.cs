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
      PrintNumbers("IDDI");

      Console.WriteLine("Press any key to exit");
      Console.ReadKey();
    }

    private static void PrintNumbers(string str)
    {
      if (str.Length == 0)
      {
        return;
      }
      StringBuilder temp = new StringBuilder();
      int dCount = 0;
      for (int i = 0; i < str.Length; i++)
      {
        if (str[i] == 'D')
        {
          dCount++;
        }
      }
      List<int> nums = new List<int>();
      for (int i = 0; i <= str.Length; i++)
      {
        nums.Add(i + 1);
      }

      //cout << endl << nums[dCount] << " ";
      temp.Append(nums[dCount] + " ");
      nums[dCount] = -1;
      int iCount = dCount + 1;
      dCount--;
      for (int i = 0; i < str.Length; i++)
      {
        if (str[i] == 'I')
        {
          //cout << nums[iCount] << " ";
          temp.Append(nums[iCount] + " ");
          nums[iCount++] = -1;
        }
        else
        {
          //cout << nums[dCount] << " ";
          temp.Append(nums[dCount] + " ");
          nums[dCount--] = -1;
        }
      }
      Console.WriteLine(temp);
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
