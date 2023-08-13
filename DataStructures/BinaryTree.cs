using System;

namespace DataStructures
{
	public class BinaryTree
	{

		class Node
		{
		       public int Data { get; set; }
                       public Node Left { get; set; }
			public Node Right { get; set; }
		
			public Node(int data) => this.Data = data;
			
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
			while (r.Right != null)
				r = r.Right;
			return r.Data;

		}
		private int min(Node node)
		{
			var r = node;
			while (r.Left != null)
				r = r.Left;
			return r.Data;
		}
		private Node remove(Node node, int a)
		{
			if (node == null)
				return null;

			if (node.Data == a)
			{

				if (node.Left == null && node.Right == null)
					return null;

				if (node.Left != null)
				{
					node.Data = max(node.Left);
					node.Left = remove(node.Left, max(node.Left));
				}
				else
				{
					node.Data = min(node.Right);
					node.Right = remove(node.Right, min(node.Right));
				}
			}

			if (node.Data < a)
				node.Right = remove(node.Right, a);
			else
				node.Left = remove(node.Left, a);
			return node;

		}

		private Node add(Node node, int a)
		{
			if (node == null)
			{
				node = new Node(a);
				return node;
			}

			if (a < node.Data)
				node.Left = add(node.Left, a);
			else
				node.Right = add(node.Right, a);

			return node;
		}

		private void traverse(Node node)
		{
			if (node == null)
				return;

			traverse(node.Left);
			Console.Write(node.Data + " ");
			traverse(node.Right);
		}
	}
}
