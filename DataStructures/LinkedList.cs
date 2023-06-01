using System.Collections;

public class LinkedList<T> : IEnumerable<T>
{
	public class Node
	{
		public T Value { get; set; }
		public Node? Previous { get; set; }
		public Node? Next { get; set; }
		public Node(T item) => Value = item;
	}

	public Node? First { get => _head; }
	public Node? Last { get => _last; }
	public int Count { get => _count; }

	private int _count;
	private Node? _head;
	private Node? _tail;
	private Node? _last;
	public Node AddLast(T item)
	{
		if (_head is null)
		{
			_head = new Node(item);
			_tail = _head;
			_last = _head;
			return _head;
		}
		Node? temp = _tail;
		_tail = _tail.Next;
		_tail = new Node(item);
		_tail.Previous = temp;
		temp.Next = _tail;
		_last = _tail;
		return _tail;
	}

	public bool Remove(T item)
	{
		Node? temp = _head;
		if (temp is null)
			return false;
		if (temp.Value.Equals(item))
		{
			_head = _head.Next;
			_head.Previous = null;
			return true;
		}
		while (temp.Next is not null && !temp.Next.Value.Equals(item))
			temp = temp.Next;
		if (temp.Next is null)
			return false;

		if (temp.Next.Next is null)
		{
			temp.Next = null;
			_last = temp;
			return true;
		}

		temp.Next = temp.Next.Next;
		temp.Next.Previous = temp;

		return true;
	}
	public bool Contains(T item)
	{
		Node? temp = _head;
		while (temp is not null)
		{
			if (temp.Value.Equals(item))
				return true;
			temp = temp.Next;
		}
		return false;
	}
	public IEnumerator<T> GetEnumerator()
	{
		Node? temp = _head;
		while (temp is not null)
		{
			yield return temp.Value;
			temp = temp.Next;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		Node? temp = _head;
		while (temp is not null)
		{
			yield return temp.Value;
			temp = temp.Next;
		}
	}
}