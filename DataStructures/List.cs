using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
	public class List<T> : IEnumerable<T>
	{
		private T[] array;
		private int index;
		public int Count { get => index; }
		public int Capacity { get => array.Length; }
		public List()
		{
			this.array = new T[4];
			index = 0;
		}
		public T this[int index]
		{
			get => array[index];
			set => array[index] = value;
		}
		public void Add(T item)
		{
			if (index < array.Length)
			{
				array[index++] = item;
				return;
			}
			Expand(array.Length);
			array[index++] = item;
		}
		public void AddRange(IEnumerable<T> collection)
		{
			IEnumerator<T> addValues = collection.GetEnumerator();
			while (addValues.MoveNext())
				Add(addValues.Current);
		}
		public void Clear()
		{
			array = new T[4];
			index = 0;
		}
		public bool Contains(T item)
		{
			for (int i = 0; i < index; i++)
				if (array[i].Equals(item))
					return true;
			return false;
		}
		public bool Remove(T item)
		{
			int rate = 2;
			if (index < array.Length / rate)
				Abridge(array.Length / rate);

			T[] values = new T[array.Length];
			int valueIndex = 0;
			for (int i = 0; i < index; i++)
				if (!array[i].Equals(item))
					values[valueIndex++] = array[i];

			array = values;
			bool result = index > valueIndex;
			index = valueIndex;
			return result;
		}
		public int RemoveAll(Predicate<T> match)
		{
			int deletedCount = 0;
			if (match == null)
				throw new ArgumentNullException();

			for (int i = 0; i < index; i++)
				if (match(array[i]))
				{
					Remove(array[i]);
					deletedCount++;
				}
			return deletedCount;
		}
		public int IndexOf(T item)
		{
			for (int i = 0; i < index; i++)
				if (array[i].Equals(item))
					return i;
			return -1;
		}
		public int LastIndexOf(T item)
		{
			int ValueIndex = -1;
			for (int i = 0; i < index; i++)
				if (array[i].Equals(item))
					ValueIndex = i;
			return ValueIndex;
		}
		public void Reverse()
		{
			for (int i = 0; i < index / 2; i++)
			{
				T temp = array[i];
				array[i] = array[index - 1 - i];
				array[index - 1 - i] = temp;
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			for (int i = 0; i < index; i++)
				yield return array[i];
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			for (int i = 0; i < index; i++)
				yield return array[i];
		}
		public void Print()
		{
			for (int i = 0; i < index; i++)
				Console.Write(array[i] + " ");
			Console.WriteLine();
		}
		private void Expand(int addCapacity)
		{
			T[] values = new T[array.Length + addCapacity];
			for (int i = 0; i < index; i++)
				values[i] = array[i];
			array = values;
		}
		private void Abridge(int removeCapacity)
		{
			T[] values = new T[array.Length - removeCapacity];
			for (int i = 0; i < index; i++)
				values[i] = array[i];
			array = values;
		}


	}
}
