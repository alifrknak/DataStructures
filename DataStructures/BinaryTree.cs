using System;

namespace DataStructures
{
	public class BinaryTree
	{

		class Node
		{
			public int data;
			public Node left;
			public Node right;

			public Node(int data) => this.data = data;
			
		}


		Node root = null;

		public void Add(int a) => root = add(root, a);

		public void Remove(int a) => remove(root, a);

		public int Max() => max(root);

		public int Min() => min(root);


		public void Traverse()
		{
			traverse(root);
			Console.WriteLine();
		}

		private int max(Node node)
		{
			var r = node;
			while (r.right != null)
				r = r.right;
			return r.data;

		}
		private int min(Node node)
		{
			var r = node;
			while (r.left != null)
				r = r.left;
			return r.data;
		}
		private Node remove(Node node, int a)
		{
			if (node == null)
				return null;

			if (node.data == a)
			{

				if (node.left == null && node.right == null)
					return null;

				if (node.left != null)
				{
					node.data = max(node.left);
					node.left = remove(node.left, max(node.left));
				}
				else
				{
					node.data = min(node.right);
					node.right = remove(node.right, min(node.right));
				}
			}

			if (node.data < a)
				node.right = remove(node.right, a);
			else
				node.left = remove(node.left, a);
			return node;

		}

		private Node add(Node node, int a)
		{
			if (node == null)
			{
				node = new Node(a);
				return node;
			}

			if (a < node.data)
				node.left = add(node.left, a);
			else
				node.right = add(node.right, a);

			return node;
		}

		private void traverse(Node node)
		{
			if (node == null)
				return;

			traverse(node.left);
			Console.Write(node.data + " ");
			traverse(node.right);
		}
	}
}
