
using HomeWork3;

Telefons telefons = new Telefons();

Console.WriteLine("Enter size mark model:");
string mark = Console.ReadLine();
string size = Console.ReadLine();
string model = Console.ReadLine();


telefons.Mark = mark;
telefons.Size = size;
telefons.Model = model;

Console.WriteLine($"Apsveicu jaunais telefons ir {telefons.Mark}:");





