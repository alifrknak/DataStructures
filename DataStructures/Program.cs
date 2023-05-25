using DataStructures;

Trie a = new Trie();
a.Add("ali");
a.Add("aliye");
a.Add("veli");
a.Add("vali");
a.Add("fatma");
a.Add("fatih");
a.Add("samet");
a.Add("veliye");


Console.WriteLine("deleted  "+a.Remove(" "));
Console.WriteLine("deleted  "+a.Remove("alii"));
Console.WriteLine("deleted  "+a.Remove("vli"));
Console.WriteLine("deleted  "+a.Remove("fat")); //hata  veliyor
Console.WriteLine("deleted  "+a.Remove("fa"));
a.Print(a);


