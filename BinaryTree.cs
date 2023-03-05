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
	}
}
