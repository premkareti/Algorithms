﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using AlgosStudy.Sorting;
using AlgosStudy.DataStructures;
using AlgosStudy.LeetCode;
using AlgosStudy.GeeksForGeeks;
using AlgosStudy.HackerEarth;

namespace AlgosStudy
{
  class Program
  {
    static void Main(string[] args)
    {
      DpSuperNaturalSquad temp = new DpSuperNaturalSquad();
      temp.NumberOfPartitions();

      Console.WriteLine("Press any key to exit");
      Console.ReadKey();
    }

    private static string PrintArray(int[] inVals)
    {
      StringBuilder temp = new StringBuilder();
      foreach (var val in inVals)
      {
        temp.Append(val + " ");
      }
      return temp.ToString();
    }
  }
}
