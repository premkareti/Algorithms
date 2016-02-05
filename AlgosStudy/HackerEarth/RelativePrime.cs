using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.HackerEarth
{
  public class RelativePrime
  {
    public int phi(int n)
    {
      int res = n;
      for (int i = 2; i * i <= n; ++i)
      {
        if (n % i == 0)
        {
          while (n % i == 0)
          {
            n /= i;
          }
          res -= res / i;
        }
      }
      if (n != 1)
      {
        res -= res / n;
      }
      return res;
    }
  }
}
