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
			var findValue = binaryTree.Find(90);
			Console.WriteLine(findValue);
			;
		}
	}
}
