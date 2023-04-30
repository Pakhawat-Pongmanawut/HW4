using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> nodes = new List<int>();
        while(true)
        {
            int node = int.Parse(Console.ReadLine());
            if(node >= n || node < 0)
            {
                break;
            }
            nodes.Add(node);
        }

        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());


        int[,] adjMatrix = new int[n, n];
        for (int i = 0; i < nodes.Count; i += 2)
        {
            int fromNode = nodes[i];
            int toNode = nodes[i + 1];
            adjMatrix[fromNode, toNode] = 1;
        }

        int[,] pathMatrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (adjMatrix[i, j] == 1)
                {
                    pathMatrix[i, j] = 1;
                }
            }
        }

        for (int k = 0; k < n; k++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (pathMatrix[i, j] != 1 && pathMatrix[i, k] == 1 && pathMatrix[k, j] == 1)
                    {
                        pathMatrix[i, j] = 1;
                    }
                }
            }
        }
        if (pathMatrix[start, end] == 1)
        {
            Console.WriteLine("Reachable");
        }
        else
        {
            Console.WriteLine("Unreachable");
        }
    }
}