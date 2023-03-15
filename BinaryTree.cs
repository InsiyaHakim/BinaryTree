using System;

namespace BinarySearchTree
{
	public class BinaryTree
	{
		public TreeNode Root;
		private static int _numberOfNodesInTree;

		public TreeNode Insert(int data)
		{
			if (data != 0)
			{
				_numberOfNodesInTree++;
				if (Root != null)
				{
					Root.Insert(data);
				}
				else
				{
					Root = new TreeNode(data);
				}
			}
			return Root;
		}

		public TreeNode Find(int value)
		{
			if (Root != null && value != 0)
			{
				//return root.Find(value);
				return Root.FindNodeRecursively(value);
			}

			throw new Exception("Invalid value, Please try again");
		}

		public TreeNode GetSmallestNode()
		{
			return Root?.GetSmallestNode();
		}
		public TreeNode GetSmallestNodeUsingRecursion()
		{
			return Root?.GetSmallestNodeUsingRecursion();
		}
		public TreeNode GetLargestNode()
		{
			return Root?.GetLargestNode();
		}
		public TreeNode GetLargestNodeUsingRecursion()
		{
			return Root?.GetLargestNodeUsingRecursion();
		}
		public TreeNode GetSmallestNodeWithoutUsingStackSpace()
		{
			return Root?.GetSmallestNodeWithoutUsingStackSpace();
		}
		public TreeNode GetLargestNodeWithoutUsingStackSpace()
		{
			return Root?.GetLargestNodeWithoutUsingStackSpace();
		}
		public int? GetHeightOfTree()
		{
			return Root?.GetHeightOfTree();
		}
		public int GetNumberOfNodesInTree()
		{
			return _numberOfNodesInTree;
		}
		public int? GetTotalNumberOfNodesInTree()
		{
			return Root?.GetTotalNumberOfNodesInTree();
		}
		public int? GetNumberOfNodes()
		{
			return Root != null ? Root.GetNumberOfNodes() + 1 : 0;
		}
		public int? GetNumberOfLeafNodes()
		{
			return Root?.GetNumberOfLeafNodes();
		}
	}
}
