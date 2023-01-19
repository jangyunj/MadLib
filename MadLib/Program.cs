string color;
string pluralNoun;
string celebrity;

Console.Write("Enter a color: ");
color = Console.ReadLine();

Console.Write("Enter a pluralNoun: ");
pluralNoun = Console.ReadLine();

Console.Write("Enter a celebrity: ");
celebrity = Console.ReadLine();

Console.WriteLine($"Roses are {color}.");
Console.WriteLine($"{pluralNoun} are blue.");
Console.WriteLine($"I love {celebrity}.");

Console.ReadLine();
