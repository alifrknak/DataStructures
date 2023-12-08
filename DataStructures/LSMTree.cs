namespace DataStructures;

public class LSMTree
{
	private SortedDictionary<string, string> memTable;
	private List<SortedDictionary<string, string>> ssTables;

	public LSMTree()
	{
		this.memTable = new SortedDictionary<string, string>();
		this.ssTables = new List<SortedDictionary<string, string>>();
	}

	public void Insert(string key, string value)
	{
		if (memTable.ContainsKey(key))
			throw new Exception("An item with the same key has already been added");

		memTable.Add(key, value);

		if (memTable.Count > 50)
		{
			FlushMemTable();
		}

	}
	public string Get(string key)
	{
		if (memTable.ContainsKey(key))
		{
			return memTable[key];
		}

		for (int i = 0; i < ssTables.Count; i++)
		{
			SortedDictionary<string, string> ssTable = ssTables[i];
			if (ssTable.ContainsKey(key))
				return ssTable[key];
		}

		return null;
	}

	private void FlushMemTable()
	{
		var newSSTable = new SortedDictionary<string, string>();

		foreach (var item in memTable)
		{
			newSSTable[item.Key] = item.Value;
		}

		ssTables.Add(newSSTable);
		memTable.Clear();
	}

}