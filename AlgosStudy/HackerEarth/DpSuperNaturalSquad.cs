using System;
using System.Linq;
using System.Text;

namespace AlgosStudy.HackerEarth
{
  /*
   * https://www.hackerearth.com/problem/algorithm/supernatural-squad-2/description/
   */

  public class DpSuperNaturalSquad
  {
    public void NumberOfPartitions()
    {
      var line1 = System.Console.ReadLine().Trim();
      var numOfTests = Int32.Parse(line1);
      StringBuilder sb = new StringBuilder();
      for (var i = 0; i < numOfTests; i++)
      {
        var temp = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var N = Int32.Parse(temp[0]);
        var K = Int32.Parse(temp[1]);
        if (K > N)
        {
          sb.Append(0);
          sb.Append(Environment.NewLine);
        }
        else
        {
          var m = N - K + 1;
          sb.Append(Count(Enumerable.Range(K, m).ToArray(), N) + Environment.NewLine);
        }
      }

      Console.WriteLine(sb);
    }

    private ulong Count(int[] S, int n)
    {
      var len = S.Length;
      ulong[,] table = new ulong[len + 1, n + 1];

      for (int i = 0; i < len + 1; i++)
        table[i, 0] = 1;

      for (int i = 1; i < n + 1; i++)
        table[0, i] = 0;

      for (int i = 1; i < len + 1; i++)
        for (int j = 1; j < n + 1; j++)
        {
          if (S[i - 1] > j)
            table[i, j] = table[i - 1, j];
          else
            table[i, j] = table[i - 1, j] + table[i, j - S[i - 1]];
        }

      return table[len, n];
    }
  }
}
