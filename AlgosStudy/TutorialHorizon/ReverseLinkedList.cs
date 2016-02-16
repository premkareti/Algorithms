using AlgosStudy.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.TutorialHorizon
{
  /*
   * http://algorithms.tutorialhorizon.com/reverse-a-linked-list/
   */
  public class ReverseLinkedList
  {
    public SinglyLLNode Reverse(SinglyLLNode head)
    {
      SinglyLLNode curr = null, prev = null, next = null;

      curr = head;
      while (curr != null)
      {
        next = curr.Next;
        curr.Next = prev;
        prev = curr;
        curr = next;
      }

      if (prev != null)
        head = prev;

      return head;
    }

    public void ReverseStack(SinglyLLNode node, SinglyLLNode head)
    {
      if (node != null && node.Next != null)
        ReverseStack(node.Next, head);

      if (node.Next == null)
        head = node;
      else
        node.Next.Next = node;
    }
  }
}
