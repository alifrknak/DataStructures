using DataStructures;
using System.IO.Compression;
using System.Security.Cryptography;

class Program
{

	static void Main(string[] args)
	{
		LinkedList<int> a = new();
		
		a.AddLast(1);
	 var  r=	a.AddLast(20);
		a.AddLast(3);
		a.AddLast(34);

		Link<int> aa = new Link<int>();

		aa.AddLast(1);
		aa.AddLast(10);
		aa.AddLast(4);

        Console.WriteLine(aa.First.Value);
        Console.WriteLine(aa.Last.Value);
        Console.WriteLine(aa.Count);

    }
}
