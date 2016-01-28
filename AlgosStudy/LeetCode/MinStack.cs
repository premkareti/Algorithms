using System;
using System.Collections.Generic;

namespace AlgosStudy.LeetCode
{
  /*
   * https://leetcode.com/problems/min-stack/
   */
  public class MinStack
  {
    private Stack<int> m_stack = new Stack<int>();
    private Stack<int> m_minStack = new Stack<int>();

    public void Push(int x)
    {
      if (m_minStack.Count == 0)
        m_minStack.Push(x);
      else
      {
        var min = Math.Min(m_minStack.Peek(), x);
        m_minStack.Push(min);
      }

      m_stack.Push(x);
    }

    public void Pop()
    {
      if (m_stack.Count != 0)
      {
        m_stack.Pop();
        m_minStack.Pop();
      }
    }

    public int Top()
    {
      return m_stack.Peek();
    }

    public int GetMin()
    {
      return m_minStack.Peek();
    }
  }
}
