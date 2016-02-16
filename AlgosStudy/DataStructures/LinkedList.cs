using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.DataStructures
{
  public class SinglyLinkedList
  {
    public SinglyLLNode Head { get; set; }

    public SinglyLinkedList(int[] inputArr)
    {
      SinglyLLNode currNode = null;
      for (int i = 0; i < inputArr.Length; i++)
      {
        var temp = new SinglyLLNode { Data = inputArr[i] };
        if (i == 0)
          Head = temp;
        else
          currNode.Next = temp;

        currNode = temp;
      }
    }

    public void Print(SinglyLLNode head)
    {
      StringBuilder temp = new StringBuilder();
      temp.Append("Head->");
      while (head != null)
      {
        temp.Append(head.Data + "->");
        head = head.Next;
      }
      temp.Append("null");
      Console.WriteLine(temp);
    }
  }

  public class SinglyLLNode
  {
    public int Data { get; set; }
    public SinglyLLNode Next { get; set; }
  }
}
