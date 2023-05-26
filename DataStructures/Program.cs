using DataStructures;
using System.Security.Cryptography;

class Program
{

	static void Main(string[] args)
	{
		Trie a = new Trie();
		
		a.Add("ali");
		a.Add("aliye");
		a.Add("veli");
		a.Add("vali");
		a.Add("fatma");
		a.Add("fatih");
		a.Add("samet");
		a.Add("veliye");
		a.Add("alim");

        Console.WriteLine(a.Remove("ali"));
        Console.WriteLine(a.Contains("ali"));
        Console.WriteLine(a.Contains("fat"));
        Console.WriteLine(a.Contains("sam"));
        Console.WriteLine(a.Contains("al"));
        Console.WriteLine(a.Contains("alii"));
        Console.WriteLine(a.Contains("al "));
        Console.WriteLine(a.Contains("va"));

    }
}