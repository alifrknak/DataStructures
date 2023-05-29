using System.Collections;

public class Link<T>: IEnumerable<T>
{
    public class Node
    {
        public T Value { get; set; }
        public Node? Previous { get; set; }
        public Node? Next { get; set; }
        public Node(T item) =>  Value = item;
    }

    public Node? First { get => _first; }
    public Node? Last { get => _last;  }
    public int Count { get => _count; }

    private  int _count;
    private Node? _first;
    private Node? _last;
    private Node? _head;
    private Node? _tail;
    public Node AddLast(T item)
    {
        if (_head is null)
        {
            _head = new Node(item);
            _tail = _head;
            _first = _head;
            return _head;
        }
        Node? temp = _tail;
		_tail.Next = new Node(item);
        _tail = _tail.Next;
        _tail.Previous = temp;
        _last = _tail; 
        return _tail;
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