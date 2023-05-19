using System.Collections;
using System;
using System.Collections.Generic;

namespace DataStructures
{
	class Stack<T> : IEnumerable<T>
	{
		
		class Node
		{
			public Node(T a) => data = a;
			
			public T data;

			public Node next;
		}
		public int Count { get => count; }

		private Node root = null;

		private int count;

		public void Push(T data)
		{
			if (root == null)
			{
				root = new Node(data);
				count++;
				return;
			}

			Node temp = root;

			while (temp.next != null)
				temp = temp.next;

			temp.next = new Node(data);

			count++;

		}
		public T Pop()
		{
			T a;

			if (root.next == null)
			{
				a = root.data;
				root = null;
				count--;
			}

			Node temp = root;

			while (temp.next.next != null)
				temp = temp.next;

			a = temp.next.data;
			temp.next = null;
			count--;

			return a;

		}
		public bool IsEmpty() =>  root == null;
		
		public T Peek()
		{
			Node temp = root;

			while (temp.next != null)
				temp = temp.next;

			return temp.data;
		}
		public void Clear()
		{
			root = null;
			count = 0;
		}
		public void Print()
		{
			Node temp = root;

			while (temp != null)
			{
				Console.Write(temp.data + " ");
				temp = temp.next;
			}
			Console.WriteLine();
		}
		public bool Contains(T data)
		{
			Node t = root;

			while (t != null)
			{
				if (t.data.Equals(data))
					return true;
				t = t.next;
			}

			return false;
		}
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			Node t = root;

			while (t != null)
			{
				yield return t.data;
				t = t.next;
			}
		}
		public IEnumerator GetEnumerator()
		{
			Node t = root;

			while (t != null)
			{
				yield return t.data;
				t = t.next;
			}
		}
	}
}
