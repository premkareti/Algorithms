using AlgosStudy.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.TutorialHorizon
{
  /*
   * http://algorithms.tutorialhorizon.com/get-the-sum-of-all-left-leaves-in-a-binary-tree/
   */
  public class LeftLeavesSum
  {
    public int Sum(TreeNode root)
    {
      if (root == null)
        return 0;

      var sum = 0;
      if (root.Left != null && root.Left.Left == null && root.Left.Right == null)
        sum += root.Left.Data;

      sum += Sum(root.Left);
      sum += Sum(root.Right);

      return sum;
    }
  }
}
