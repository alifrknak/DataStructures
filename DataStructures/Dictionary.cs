
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
	public class Dictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
	{
		private int index;
		public int Count { get => index; }
		public TKey[] Keys { get; set; }
		public TValue[] Values { get; set; }

		public Dictionary()
		{
			Keys = new TKey[4];
			Values = new TValue[4];
		}
		public void Add(TKey key, TValue value)
		{
			if (index < Keys.Length)
			{
				Keys[index] = key;
				Values[index++] = value;
				return;
			}
			Expand(Keys.Length);
			Keys[index] = key;
			Values[index++] = value;
		}
		private void Expand(int addCapacity)
		{
			TKey[] tempKeys = new TKey[Keys.Length + addCapacity];
			for (int i = 0; i < index; i++)
				tempKeys[i] = Keys[i];
			Keys = tempKeys;

			TValue[] tempValues = new TValue[Values.Length + addCapacity];
			for (int i = 0; i < index; i++)
				tempValues[i] = Values[i];
			Values = tempValues;

		}
		private void Abridge(int removeCapacity)
		{
			TKey[] tempKeys = new TKey[Keys.Length - removeCapacity];
			for (int i = 0; i < index; i++)
				tempKeys[i] = Keys[i];
			Keys = tempKeys;

			TValue[] tempValues = new TValue[Values.Length - removeCapacity];
			for (int i = 0; i < index; i++)
				tempValues[i] = Values[i];
			Values = tempValues;

		}
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			for (int i = 0; i < index; i++)
				yield return new KeyValuePair<TKey, TValue>(key: Keys[i], value: Values[i]);
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			for (int i = 0; i < index; i++)
				yield return new KeyValuePair<TKey, TValue>(key: Keys[i], value: Values[i]);
		}
		public void Print()
		{
			foreach (var i in this)
				Console.WriteLine(i.Key + " " + i.Value);
			Console.WriteLine();
		}

		public void Remove()
		{

		}
	}
}