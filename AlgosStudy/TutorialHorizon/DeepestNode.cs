using AlgosStudy.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.TutorialHorizon
{
  /*
   * http://algorithms.tutorialhorizon.com/find-the-deepest-node-in-a-binary-tree/
   */
  public class DeepestNode
  {
    private static int deepestlevel = 0;


    public void FindDeepest(TreeNode root, int level, ref int deepNodeData)
    {
      if (root != null)
      {
        if (level > deepestlevel)
        {
          deepestlevel = level;
          deepNodeData = root.Data;
        }
        FindDeepest(root.Left, level + 1, ref deepNodeData);
        FindDeepest(root.Right, level + 1, ref deepNodeData);
      }
    }
  }
}
