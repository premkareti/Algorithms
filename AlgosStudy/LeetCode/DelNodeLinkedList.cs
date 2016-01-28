using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/delete-node-in-a-linked-list/
   */

  //Definition for singly-linked list.
  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
  }


  public class DelNodeLinkedList
  {
    public void DeleteNode(ListNode node)
    {
      if (node != null)
      {
        if (node.next != null)
        {
          node.val = node.next.val;
          node.next = node.next.next;
        }
        else
          node = node.next;
      }
    }

  }
}
