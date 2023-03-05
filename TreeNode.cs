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
			if(value >= data)
			{
				if(rightNode == null)
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
				if(value <= data)
				{
					if(leftNode == null)
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
	}
}
