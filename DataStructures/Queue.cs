using System;

namespace DataStructures
{
	public class Queue<T>
	{
		private class Node
		{
			public Node(T a) => data = a;
			public T data { get; set; }
			public Node next { get; set; }
		}
		public int Count { get => count; }
		private int count;
		private Node root;

		public void Enqueue(T item)
		{
			if (root == null)
			{
				root = new Node(item);
				count++;
				return;
			}

			Node iter = root;
			while (iter.next != null)
				iter = iter.next;

			iter.next = new Node(item);
			count++;

		}
		public T Dequeue()
		{
			if (root == null)
				throw new NullReferenceException();
			T returnValue = root.data;
			root = root.next;
			count--;
			return returnValue;
		}
		public T Peek()
		{
			return root.data;

		}
		public void Clear()
		{
			root = null;
			count = 0;
		}
		public bool Contains(T item)
		{
			Node iter = root;
			while (iter.next != null)
			{
				if (iter.data.Equals(item))
					return true;
				iter = iter.next;
			}
			return false;
		}

		public void Print()
		{
			Node iter = root;
			while (iter != null)
			{
				Console.Write(iter.data + " ");
				iter = iter.next;
			}
			Console.WriteLine();
		}
	}
}
