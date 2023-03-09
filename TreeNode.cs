using System;

namespace BinarySearchTree
{
	public class TreeNode
	{
		public int data { get; set; }
		public TreeNode rightNode { get; set; }
		public TreeNode leftNode { get; set; }


		public TreeNode(int value)
		{
			data = value;
		}

		public TreeNode Insert(int value)
		{
			if (value >= data)
			{
				if (rightNode == null)
				{
					rightNode = new TreeNode(value);
				}
				else
				{
					rightNode.Insert(value);
				}
			}
			else
			{
				if (value <= data)
				{
					if (leftNode == null)
					{
						leftNode = new TreeNode(value);
					}
					else
					{
						leftNode.Insert(value);
					}
				}
			}

			return this;
		}

		public TreeNode Find(int value)
		{
			TreeNode currentNode = this;

			while (currentNode != null)
			{
				if (currentNode.data == value) return currentNode;

				currentNode = value < currentNode.data
					? currentNode.leftNode
					: currentNode.rightNode;
			}

			throw new Exception("Cannot find this value");
		}

		public TreeNode FindNodeRecursively(int value)
		{	
			//This is to check current value in our stack
			//var currentNode = this.data;
			if (data == value) return this;

			if (value < data)
			{
				leftNode.FindNodeRecursively(value);
			}
			else if (value > data)
			{
				rightNode.FindNodeRecursively(value);
			}
			
			return null ;
		}

		public TreeNode GetSmallestNode()
		{
			var currentNode = this;

			while (currentNode.leftNode != null) currentNode = currentNode.leftNode;

			return currentNode;
		}
		public TreeNode GetSmallestNodeUsingRecursion()
		{
			if (leftNode == null)
			{
				return this;
			}
			
			return leftNode.GetSmallestNodeUsingRecursion();
		}

		public TreeNode GetLargestNode()
		{
			var currentNode = this;

			while (currentNode.rightNode != null) currentNode = currentNode.rightNode;

			return currentNode;
		}

		public TreeNode GetLargestNodeUsingRecursion()
		{
			if (rightNode == null)
			{
				return this;
			}

			return rightNode.GetLargestNodeUsingRecursion();
		}
	}
}

