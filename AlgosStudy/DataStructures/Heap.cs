using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.DataStructures
{
  public class Heap
  {
    //private ArrayList m_heapStore = new ArrayList();
    private int[] m_heapStore;
    private bool m_isMinHeap = true;

    public Heap(int[] inputArray, bool isMinHeap = true)
    {
      //m_heapStore.AddRange(inputArray);
      m_isMinHeap = isMinHeap;
      m_heapStore = new int[inputArray.Length];
      inputArray.CopyTo(m_heapStore, 0);
      for (int i = (m_heapStore.Length / 2) - 1; i >= 0; i--)
      {
        BubbleDown(i);
      }
    }

    public void Add(int element)
    {
      var tempArr = new int[m_heapStore.Length];
      m_heapStore.CopyTo(tempArr, 0);
      m_heapStore = new int[tempArr.Length + 1];
      tempArr.CopyTo(m_heapStore, 0);
      m_heapStore[tempArr.Length] = element;
      BubbleUp(m_heapStore.Length - 1);
    }

    public int GetMinElement()
    {
      return m_heapStore[0];
    }

    public int ExtractMinElement()
    {
      var tempArr = new int[m_heapStore.Length];
      m_heapStore.CopyTo(tempArr, 0);
      var min = m_heapStore[0];
      tempArr[0] = tempArr[tempArr.Length - 1];
      m_heapStore = new int[tempArr.Length - 1];
      for (int i = 0; i < m_heapStore.Length; i++)
      {
        m_heapStore[i] = tempArr[i];
      }
      BubbleDown(0);

      return min;
    }

    private void BubbleUp(int nodeIndex)
    {
      var parentIndex = Parent(nodeIndex);
      while (parentIndex != -1)
      {
        if (m_heapStore[nodeIndex] < m_heapStore[parentIndex])
        {
          Utilities.SwapElementsAtIndexes(m_heapStore, nodeIndex, parentIndex);
          nodeIndex = parentIndex;
          parentIndex = Parent(nodeIndex);
        }
        else
          break;
      }
    }

    private void BubbleDown(int parentIndex)
    {
      while (parentIndex < m_heapStore.Length &&
            parentIndex != -1)
      {
        var leftIndex = LeftChildIndex(parentIndex);
        var rightIndex = RightChildIndex(parentIndex);
        var currMin = parentIndex;
        if (leftIndex != -1)
        {
          if (m_heapStore[leftIndex] < m_heapStore[currMin])
            currMin = leftIndex;
          if (rightIndex != -1 && m_heapStore[rightIndex] < m_heapStore[currMin])
            currMin = rightIndex;
        }

        if (currMin != parentIndex)
        {
          Utilities.SwapElementsAtIndexes(m_heapStore, parentIndex, currMin);
          parentIndex = currMin;
        }
        else
          break;
      }
    }

    private int LeftChildIndex(int parentIndex)
    {
      var temp = (2 * parentIndex) + 1;

      if (temp >= m_heapStore.Length)
        return -1;

      return temp;
    }

    private int RightChildIndex(int parentIndex)
    {
      var temp = (2 * parentIndex) + 2;

      if (temp >= m_heapStore.Length)
        return -1;

      return temp;
    }

    private int Parent(int childIndex)
    {
      if (childIndex <= 0)
        return -1;

      return (childIndex % 2 == 0) ? ((childIndex / 2) - 1) : (childIndex / 2);
    }

  }
}
