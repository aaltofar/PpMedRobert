Random r = new Random();

bool headOrTails = r.Next(2) != 0;
Console.WriteLine("Heads[1] or tails[2]?");

var input = Console.ReadLine();

string toPrint = headOrTails ? "Heads" : "Tails";

if (headOrTails && input == "1" || !headOrTails && input == "2")
    Console.WriteLine($"{toPrint}, you win!");
else
    Console.WriteLine($"{toPrint}, womp womp");

