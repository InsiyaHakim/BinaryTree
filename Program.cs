using System;

namespace BinarySearchTree
{
	class Program
	{
		static void Main(string[] args)
		{
			BinaryTree binaryTree = new();

			binaryTree.Insert(75);
			binaryTree.Insert(56);
			binaryTree.Insert(90);
			binaryTree.Insert(32);
			binaryTree.Insert(7);
			binaryTree.Insert(44);
			binaryTree.Insert(60);
			binaryTree.Insert(86);
			binaryTree.Insert(99);


			//var findValue = binaryTree.Find(11);
			//var findValue = binaryTree.Find(0);
			//var findValue = binaryTree.Find(99);

			/*var smallestValue = binaryTree.GetSmallestNode();
			Console.WriteLine(smallestValue);*/

			//var smallestValue = binaryTree.GetSmallestNodeUsingRecursion();
			//Console.WriteLine(smallestValue);

			/*var largestValue = binaryTree.GetLargestNode();
			Console.WriteLine(largestValue);*/

			/*var largestValue = binaryTree.GetLargestNodeUsingRecursion();
			Console.WriteLine(largestValue);*/

			/*var getSmallestNodeWithoutUsingStackSpace = binaryTree.GetSmallestNodeWithoutUsingStackSpace();
			Console.WriteLine(getSmallestNodeWithoutUsingStackSpace.data);*/
			
		/*	var getLargestNodeWithoutUsingStackSpace = binaryTree.GetLargestNodeWithoutUsingStackSpace();
			Console.WriteLine(getLargestNodeWithoutUsingStackSpace.data);*/
			
			/*var GetHeightOfTree = binaryTree.GetHeightOfTree();
			Console.WriteLine(GetHeightOfTree);*/
			
			var getTotalNumberOfNodesInTree = binaryTree.GetTotalNumberOfNodesInTree();
			Console.WriteLine(getTotalNumberOfNodesInTree);
			Console.WriteLine(binaryTree.GetNumberOfNodesInTree());

			


		}
	}
}
