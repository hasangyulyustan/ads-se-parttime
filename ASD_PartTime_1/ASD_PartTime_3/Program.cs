using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_PartTime_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             // Tree example
             * 
             Tree<int> tree =
			new Tree<int>(7,
				new Tree<int>(19,
					new Tree<int>(1),
					new Tree<int>(12),
					new Tree<int>(31)),
				new Tree<int>(21),
				new Tree<int>(14,
					new Tree<int>(23),
					new Tree<int>(6))
			);

		Console.WriteLine("Depth-First Search (DFS) traversal (recursive):");
		tree.TraverseDFS();
		Console.WriteLine();

		Console.WriteLine("Breadth-First Search (BFS) traversal (with queue):");
		tree.TraverseBFS();
		Console.WriteLine();

		Console.WriteLine();
		Console.WriteLine("Depth-First Search (DFS) traversal (with stack):");
		tree.TraverseDFSWithStack();
		Console.WriteLine();
             
             */


            /*
               //Graph example
               Graph g = new Graph(new int[][] {
              new int[] {3, 6}, // successors of vertice 0
              new int[] {2, 3, 4, 5, 6}, // successors of vertice 1
              new int[] {1, 4, 5}, // successors of vertice 2
              new int[] {0, 1, 5}, // successors of vertice 3
              new int[] {1, 2, 6}, // successors of vertice 4
              new int[] {1, 2, 3}, // successors of vertice 5
              new int[] {0, 1, 4}  // successors of vertice 6
          });

          Console.Write("Breadth-First Search (BFS) traversal: ");
          g.TraverseBFS(0);
          Console.WriteLine();

          Console.Write("Depth-First Search (DFS) traversal (with stack): ");
          g.TraverseDFS(0);
          Console.WriteLine();

          Console.Write("Depth-First Search (DFS) traversal (recursive): ");
          bool[] visited = new bool[Graph.MaxNode];
          g.TraverseDFSRecursive(0, visited);
          Console.WriteLine();
           */


            // Create the binary tree from the sample

            BinaryTree<int> binaryTree =

                  new BinaryTree<int>(14,

                              new BinaryTree<int>(19,

                                          new BinaryTree<int>(23),

                                          new BinaryTree<int>(6,

                                                      new BinaryTree<int>(10),

                                                      new BinaryTree<int>(21))),

                              new BinaryTree<int>(15,

                                          new BinaryTree<int>(3),

                                          null));



            // Traverse and print the tree in in-order manner

            binaryTree.PrintInorder();



            // Console output:

            // 23 19 10 6 21 14 3 15

        }
    }
}
