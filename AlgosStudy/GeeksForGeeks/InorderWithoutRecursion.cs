using AlgosStudy.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosStudy.GeeksForGeeks
{
  /*
   * http://www.geeksforgeeks.org/inorder-tree-traversal-without-recursion/
   */
  public class InorderWithoutRecursion
  {
    public void Traversal(TreeNode root)
    {
      StringBuilder res = new StringBuilder();
      Stack<TreeNode> stack = new Stack<TreeNode>();
      TreeNode current = root;

      while (stack.Count != 0 || current != null)
      {
        if (current != null)
        {
          stack.Push(current);
          current = current.Left;
        }
        else
        {
          var ele = stack.Pop();
          res.Append(ele.Data + " ");
          current = ele.Right;
        }
      }
      Console.WriteLine(res);
    }
  }
}
