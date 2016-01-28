
namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/add-digits/
   */

  public class AddDigits
  {
    public int AddDigitsFun(int num)
    {

      if (num == 0)
        return 0;

      var temp = num % 9;

      if (temp == 0)
        return 9;
      else
        return temp;
    }
  }
}
