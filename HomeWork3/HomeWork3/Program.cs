
using HomeWork3;

Console.WriteLine();
Console.WriteLine("======================telefons");
Console.WriteLine();

//Telefons telefons = new Telefons();

//Console.WriteLine("Enter size mark model:");

//string mark = Console.ReadLine();
//string size = Console.ReadLine();
//string model = Console.ReadLine();


//telefons.Mark = mark;
//telefons.Size = size;
//telefons.Model = model;

//Console.WriteLine($"Apsveicu jaunais telefons ir {telefons.Mark}:");


Console.WriteLine();
Console.WriteLine("======================car");
Console.WriteLine();

Car car = new Car();

Console.WriteLine("Enter brand numberPlate speed:");

string brand = Console.ReadLine();
string numberPlate = Console.ReadLine();
string speed = Console.ReadLine();


car.Brand = brand;
car.NumberPlate = numberPlate;
car.Speed = 10;


Console.WriteLine($"Jaunā mašīna ir {car.Brand}:");

speed = speed;
Console.WriteLine("Sākam braukt");

speed += 10;
Console.WriteLine("Ātrums - " + speed);
return speed;








