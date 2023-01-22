// See https://aka.ms/new-console-template for more information
string konfig = "Fullscreen shaDows autosave";
konfig = konfig.ToLower();
Console.WriteLine("Poběží hra ve fullscreenu?");
Console.WriteLine(konfig.Contains("Fullscreen"));
Console.WriteLine("Budou zapnuté stíny?");
Console.WriteLine(konfig.Contains("shadows"));
Console.WriteLine("Přeje si hráč vypnout zvuk?");
Console.WriteLine(konfig.Contains("nosound"));
Console.WriteLine("Přeje si hráč automaticky hru ukládat?");
Console.WriteLine(konfig.Contains("autosave"));
Console.ReadKey();
