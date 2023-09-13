using System.Collections;
using System.Runtime.CompilerServices;

namespace DataStructures;

partial class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine();
		new System.Collections.Generic.HashSet<int>();
	}
}
public class HashSet
{
	public int Count { get; private set; }
	public int Capacity { get; private set; } = 20;

	private int[] table;

	public HashSet(int capacity)
	{
		table = new int[capacity];
		Capacity = capacity;
	}
	public HashSet()
	{
		table = new int[Capacity];
	}

	private int Hash(int key) => key % Capacity;

	public bool Add(int item)
	{

	}
}