using System;

namespace BinarySearchTree
{
	public class BinaryTree
	{
		public TreeNode root;

		public TreeNode Insert(int data)
		{
			if (data != 0)
			{
				if (root != null)
				{
					root.Insert(data);
				}
				else
				{
					root = new TreeNode(data);
				}
			}
			return root;
		}

		public TreeNode Find(int value)
		{
			if (root != null && value != 0)
			{
				return root.Find(value);
			}

			throw new Exception("Invalid value, Please try again");
		}
	}
}
