using System;

namespace BinarySearchTree
{
	public class TreeNode
	{
		public int data { get; set; }
		public TreeNode rightNode { get; set; }
		public TreeNode leftNode { get; set; }

		private static int Count;


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
			var currentNode = this;// although this line is 0(1) operation but here we are using extra space assigning this value

			while (currentNode.leftNode != null) currentNode = currentNode.leftNode;

			return currentNode;
		}
		public TreeNode GetSmallestNodeWithoutUsingStackSpace()
		{
			//here no extra space is utilized

			if (leftNode == null) return this;

			while (leftNode.leftNode != null) leftNode = leftNode.leftNode;

			return leftNode;
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
		public TreeNode GetLargestNodeWithoutUsingStackSpace()
		{
			//here no extra space is utilized

			if (rightNode == null) return this;

			while (rightNode.rightNode != null) rightNode = rightNode.rightNode;

			return rightNode;
		}
		public TreeNode GetLargestNodeUsingRecursion()
		{
			if (rightNode == null)
			{
				return this;
			}

			return rightNode.GetLargestNodeUsingRecursion();
		}

		public int GetHeightOfTree()
		{
			var currentNode = this;
			if (currentNode.leftNode == null || currentNode.rightNode == null)
			{
				return 1;
			}

			int left = leftNode.GetHeightOfTree();
			int right = rightNode.GetHeightOfTree();

			var result = Math.Max(left, right) + 1;
			return result;
		}

		public int GetTotalNumberOfNodesInTree()
		{
			var currentNode = this;
			++Count;

			if (currentNode.leftNode == null || currentNode.rightNode == null)
			{
				return 0;
			}

			leftNode.GetTotalNumberOfNodesInTree();
			rightNode.GetTotalNumberOfNodesInTree();

			return Count;
		}

		public int GetNumberOfLeafNodes()
		{
			if (this.leftNode == null && this.rightNode == null)
			{
				return 1;
			}

			var leftLeaf = leftNode?.GetNumberOfLeafNodes() ?? 0;
			var rightLeaf = rightNode?.GetNumberOfLeafNodes() ?? 0;

			return leftLeaf + rightLeaf;
		}

		public int GetNumberOfNodes()
		{
			if (leftNode == null || this.rightNode == null)
			{
				return 0;
			}

			var leftLeaf = (int)leftNode?.GetNumberOfNodes();
			leftLeaf += 1;
			var rightLeaf = (int)rightNode?.GetNumberOfNodes();
			rightLeaf += 1;

			return leftLeaf + rightLeaf;
		}
	}
}

