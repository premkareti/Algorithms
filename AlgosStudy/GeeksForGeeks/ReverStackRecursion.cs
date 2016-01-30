using System.Collections.Generic;

namespace AlgosStudy.GeeksForGeeks
{
  /*
   * http://www.geeksforgeeks.org/reverse-a-stack-using-recursion/
   */
  public class ReverseStackRecursion
  {
    public void ReverseStack(Stack<int> stack, int item)
    {
      if (stack.Count != 0)
      {
        ReverseStack(stack, stack.Pop());
      }

      InsertItemAtEnd(stack, item);
    }

    private void InsertItemAtEnd(Stack<int> stack, int item)
    {
      if (stack.Count != 0)
      {
        var t = stack.Pop();
        InsertItemAtEnd(stack, item);
        stack.Push(t);
      }
      else
        stack.Push(item);
    }
  }
}
