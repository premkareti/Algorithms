using AlgosStudy.DataStructures;
using System.Text;

namespace AlgosStudy.GeeksForGeeks
{
  /*
   * http://www.geeksforgeeks.org/print-ancestors-of-a-given-node-in-binary-tree/
   */
  public class PrintAncestor
  {
    public bool Display(TreeNode root, int nodeToFind, StringBuilder temp)
    {
      if (root == null)
        return false;

      if (root.Data == nodeToFind)
        return true;

      if (Display(root.Left, nodeToFind, temp) ||
         Display(root.Right, nodeToFind, temp))
      {
        temp.Append(root.Data + " ");
        return true;
      }

      return false;
    }
  }
}
