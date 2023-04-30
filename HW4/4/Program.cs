using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());

        List<int> nodes = new List<int>();
        while (true)
        {
            int node1 = int.Parse(Console.ReadLine());
            if(node1 >= m || node1 < 0)
            {
                break;
            }
            int node2 = int.Parse(Console.ReadLine());
            if(node2 >= m || node2 < 0)
            {
                break;
            }
            if(node1 == node2)
            {
                break;
            }
            else
            {
                nodes.Add(node1);
                nodes.Add(node2);
            }
        }

        HashSet<int> usedSymbols = new HashSet<int>();
        foreach (int node in nodes) 
        {
            usedSymbols.Add(node % m);
        }
        int Symbols = usedSymbols.Count - 2;
        Console.WriteLine("Ans: {0}",Symbols);
    }
}