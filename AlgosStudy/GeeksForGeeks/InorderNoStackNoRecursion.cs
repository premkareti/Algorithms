using AlgosStudy.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.GeeksForGeeks
{
  public class InorderNoStackNoRecursion
  {
    public string InorderTraversal(TreeNode root)
    {
      if (root == null)
        return String.Empty;

      StringBuilder temp = new StringBuilder();
      TreeNode current = root;

      while (current != null)
      {
        if (current.Left == null)
        {
          temp.Append(current.Data + " ");
          current = current.Right;
        }
        else
        {
          TreeNode pre = current.Left;
          while (pre != null && pre.Right != null && pre.Right != current)
            pre = pre.Right;

          if (pre.Right == null)
          {
            pre.Right = current;
            current = current.Left;
          }
          else
          {
            pre.Right = null;
            temp.Append(current.Data + " ");
            current = current.Right;
          }
        }
      }

      return temp.ToString();
    }
  }
}
