using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosStudy.DataStructures
{
  public class Graph
  {
    public class Vertex
    {
      public int label { get; set; }
      public int distance { get; set; }
      public Vertex ancestor { get; set; }

      public override bool Equals(object obj)
      {
        return this.label == (obj as Vertex).label;
      }

      public override int GetHashCode()
      {
        return label;
      }
    }

    private Dictionary<Vertex, List<Vertex>> m_adjList;
    private readonly int m_vertices;

    public Graph(List<int>[] adjList, int numOfVertices)
    {
      m_vertices = numOfVertices;
      m_adjList = new Dictionary<Vertex, List<Vertex>>();
      for (int i = 0; i < numOfVertices; i++)
      {
        var k = GetVertex(i);
        if (m_adjList.ContainsKey(k))
        {
          adjList[i].ForEach(e =>
          {
            var v = GetVertex(e);
            if (v != null)
              m_adjList[k].Add(v);
          });
        }
        else
        {
          var tempList = adjList[i]
                         .TakeWhile(e => GetVertex(e) != null)
                         .Select(l => GetVertex(l))
                         .ToList();
          m_adjList.Add(k, tempList);
        }
      }
    }

    private Vertex GetVertex(int label_v)
    {
      if (label_v == -1)
        return null;

      var k = m_adjList.Keys.Where(val => val.label == label_v).SingleOrDefault();
      if (k == null)
      {
        k = new Vertex { label = label_v };
      }

      return k;
    }

    public void BFS(int label_v)
    {
      Vertex vertex = new Vertex { label = label_v };
      bool[] discovered = new bool[m_vertices];
      bool[] processed = new bool[m_vertices];

      StringBuilder temp = new StringBuilder();
      Queue<Vertex> discoveredVertices = new Queue<Vertex>();
      discoveredVertices.Enqueue(vertex);
      discovered[vertex.label] = true;

      while (discoveredVertices.Count != 0)
      {
        var u = discoveredVertices.Dequeue();
        temp.Append(u.label + "--> ");
        m_adjList[u].ForEach(e =>
        {
          if (!discovered[e.label])
          {
            discoveredVertices.Enqueue(e);
            e.ancestor = u;
            e.distance = u.distance + 1;
            discovered[e.label] = true;
          }
        });

        processed[u.label] = true;
      }

      temp.Append(Environment.NewLine + "Distances: ");
      Dictionary<int, int> dist = m_adjList.ToDictionary(keyv => keyv.Key.label, keyv => keyv.Key.distance);
      foreach (var kv in dist)
      {
        temp.Append("Label: " + kv.Key + ", Distance: " + kv.Value + Environment.NewLine);
      }

      Console.WriteLine(temp.ToString());
    }

  }
}
