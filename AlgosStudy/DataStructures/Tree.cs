using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.DataStructures
{
  public class TreeNode
  {
    public int Data { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }
  }

  public class Tree
  {
    public TreeNode CreateTree(object[] inputVals)
    {
      Dictionary<int, TreeNode> treeMap = new Dictionary<int, TreeNode>();
      var len = inputVals.Length;
      for (int i = 0; i < len; i++)
      {
        if (inputVals[i] == null)
          treeMap.Add(i, null);
        else
          treeMap.Add(i, new TreeNode { Data = (int)inputVals[i] });
      }

      TreeNode root = null;
      for (int i = 0; i < len; i++)
      {
        int left = (2 * i) + 1;
        int right = (2 * i) + 2;
        if (left < len && treeMap[i] != null)
          treeMap[i].Left = treeMap[left];
        if (right < len && treeMap[i] != null)
          treeMap[i].Right = treeMap[right];

        if (i == 0)
          root = treeMap[i];
      }

      return root;
    }

    public void PrintTree(TreeNode root, int level, StringBuilder temp)
    {
      if (root == null && level >= 0)
      {
        temp.Append("null ");
        return;
      }

      if (level == 0)
        temp.Append(root.Data + " ");

      if (level > 0)
      {
        PrintTree(root.Left, level - 1, temp);
        PrintTree(root.Right, level - 1, temp);
      }
    }

    public int TreeHeight(TreeNode root)
    {
      if (root == null)
        return 0;

      return 1 + Math.Max(TreeHeight(root.Left), TreeHeight(root.Right));
    }

    public string DisplayTree(TreeNode root)
    {
      StringBuilder res = new StringBuilder();
      var height = TreeHeight(root);
      for (int i = 0; i < height; i++)
      {
        StringBuilder temp = new StringBuilder();
        PrintTree(root, i, temp);
        res.Append(temp + Environment.NewLine);
      }

      return res.ToString();
    }
  }

}
