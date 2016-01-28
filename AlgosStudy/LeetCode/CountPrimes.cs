
namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/count-primes/
   */
  public class CountPrimesOfNum
  {
    public int CountPrimes(int n)
    {
      if (n == 0 || n == 1 || n == 2)
        return 0;
      int count = 0;
      int[] arr = new int[n];
      for (int i = 2; i * i <= n && i < n; i++)
      {
        if (arr[i] != 1)
        {
          for (int j = i + 1; j < n; j++)
          {
            if (arr[j] == 0 && j % i == 0)
            {
              arr[j] = 1;
              count++;
            }
          }
        }
      }
      return n - count - 2;
    }
  }
}
