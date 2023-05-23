public class Trie
{
	public bool IsEndOfWord { get; set; }

	public Dictionary<char, Trie> Children { get; set; } = new();

	public void Add(string word)
	{
		Trie current = this;

		foreach (var c in word)
		{
			if (!current.Children.TryGetValue(c, out var child))
				current.Children.Add(c, child = new Trie());
			current = child;
		}
		current.IsEndOfWord = true;
	}
	public bool Contains(string word)
	{
		Trie current = this;
		for (int i = 0; i < word.Length; i++)
			if (!current.Children.TryGetValue(word[i], out current))
				return false;
		return current.IsEndOfWord;
	}
	

	public void Print(Trie trie)
	{
		if (trie is null)
		{
			return;
		}
		foreach (var i in trie.Children.Keys)
		{
			Console.Write(i + " ");
		}
		Console.WriteLine();
		foreach (var i in trie.Children.Values)
		{
			Print(i);
		}

	}

}