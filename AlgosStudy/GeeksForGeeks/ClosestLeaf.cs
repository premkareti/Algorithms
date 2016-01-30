using AlgosStudy.DataStructures;
using System;

namespace AlgosStudy.GeeksForGeeks
{
  /*
   * http://www.geeksforgeeks.org/closest-leaf-to-a-given-node-in-binary-tree/
   */
  public class ClosestLeaf
  {
    public int DistCount(TreeNode temp)
    {
      if (temp == null)
        return 0;

      return 1 + Math.Min(DistCount(temp.Left), DistCount(temp.Right));
    }
  }
}
