using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresChapter16
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph theGraph = new Graph();
            theGraph.AddVertex("CS1");
            theGraph.AddVertex("CS2");
            theGraph.AddVertex("DS");
            theGraph.AddVertex("OS");
            theGraph.AddVertex("ALG");
            theGraph.AddVertex("AL");
            theGraph.AddEdge(0, 1);
            theGraph.AddEdge(1, 2);
            theGraph.AddEdge(1, 5);
            theGraph.AddEdge(2, 3);
            theGraph.AddEdge(2, 4);
            theGraph.TopSort();
            Console.WriteLine();
            Console.WriteLine("Finished.");
            Console.ReadLine();
        }
    }
}
