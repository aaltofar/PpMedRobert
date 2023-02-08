

//delelig med 3 print Fizz
//delelig med 5 print Buzz
//delelig med begge print FizzBuzz
//Ellers print tallene

List<int> nums = new();

for (int i = 1; i < 51; i++)
    nums.Add(i);

foreach (var num in nums)
{
    if (num % 3 == 0)
        Console.WriteLine("Fizz!!!!");
    if (num % 5 == 0)
        Console.WriteLine("Buzz!!!!");
    if (num % 3 == 0 && num % 5 == 0)
        Console.WriteLine("FizzBuzz!!!!");
    else
        Console.WriteLine(num);

}
