public class Trie
{
	public bool IsEndOfWord { get; set; }

<<<<<<< HEAD
	public Dictionary<char, Trie> Children { get; set; } = new();
=======
	public Dictionary<char, Trie>? Children { get; set; } = new();
>>>>>>> 84d0b56576278d15f5cbc56fa0708fb45d5a8bb0

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
<<<<<<< HEAD

		for (int i = 0; i < word.Length; i++)
			if (!current.Children.TryGetValue(word[i], out current))
				return false;
		return current.IsEndOfWord;
	}
	
=======
		foreach (var c in word)
			if (!current.Children.TryGetValue(c, out current))
				return false;
		return current.IsEndOfWord;
	}
>>>>>>> 84d0b56576278d15f5cbc56fa0708fb45d5a8bb0

	public void Print(Trie trie)
	{
		if (trie is null)
		{
			return;
		}
<<<<<<< HEAD
		foreach (var i in trie.Children.Keys)
		{
			Console.Write(i + " ");
		}
		Console.WriteLine();
		foreach (var i in trie.Children.Values)
=======
        foreach (var i in trie.Children.Keys)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
        foreach (var i in trie.Children.Values)
>>>>>>> 84d0b56576278d15f5cbc56fa0708fb45d5a8bb0
		{
			Print(i);
		}

	}
<<<<<<< HEAD

=======
>>>>>>> 84d0b56576278d15f5cbc56fa0708fb45d5a8bb0
}