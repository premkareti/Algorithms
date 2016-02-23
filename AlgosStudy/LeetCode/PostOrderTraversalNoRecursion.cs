using AlgosStudy.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.LeetCode
{
  public class PostOrderTraversalNoRecursion
  {
    public IList<int> Traversal(TreeNode root)
    {
      List<int> res = new List<int>();
      if (root == null)
        return res;

      Stack<TreeNode> temp = new Stack<TreeNode>();
      TreeNode cur = root;

      while (cur != null || temp.Count != 0)
      {
        if (cur != null)
        {
          temp.Push(cur);
          cur = cur.Left;
        }
        else
        {
          var e = temp.Peek();
          if (e.Right != null)
          {
            cur = e.Right;
            e.Right = null;
          }
          else
          {
            res.Add(temp.Pop().Data);
          }
        }
      }

      return res;
    }
  }
}
