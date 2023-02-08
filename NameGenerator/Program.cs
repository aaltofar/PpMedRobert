//  Name Generator
//  Heads/Tails
//  Temperature Converter
//  Calculate age in seconds
//  Encryption/Decryption algorithm
//  FizzBuzz
//  Rock, Paper, Scissors
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Random r = new Random();

string[] vowels = { "a", "e", "i", "o", "u", "y", "æ", "ø", "å" };
string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x", "z" };

RandomName(8, r, consonants, vowels);

static void RandomName(int nameLength, Random r, string[] consonants, string[] vowels)
{
    string name = "";

    while (name.Length < nameLength)
    {
        name += consonants[r.Next(0, consonants.Length)];

        if (name.Length == nameLength) // breake på oddetall
            break; // bytte ut med continue?


        name += vowels[r.Next(0, vowels.Length)];

    }

    Console.WriteLine(name);
}