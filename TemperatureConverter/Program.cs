// To convert temperatures in degrees Fahrenheit to Celsius, subtract 32 and multiply by .5556 (or 5/9).

// To convert temperatures in degrees Celsius to Fahrenheit, multiply by 1.8 (or 9/5) and add 32.

// Example: (50°F - 32) x .5556 = 10°C


Console.WriteLine(@"
Velcummen til temperatur endrer'n!

Hva vil du endre FRA?

[1] = Celsius
[2] = Fahrenheit
[3] = Kelvin

");

var convertFrom = Console.ReadLine();
Console.Clear();
Console.WriteLine("Hva vil du endre til?");
Console.WriteLine(@"
[1] = Celsius
[2] = Fahrenheit
[3] = Kelvin
");
var convertTo = Console.ReadLine();
Console.Clear();
Console.WriteLine("Skriv inn tallet du vil konvertere");
double.TryParse(Console.ReadLine(), out double numToConvert);

if (convertTo == "1")
    Console.WriteLine(ConvertToCelsius(convertFrom, numToConvert).ToString("N1"));

if (convertTo == "2")
    Console.WriteLine(ConvertToFahrenheit(convertFrom, numToConvert).ToString("N1"));

if (convertTo == "3")
    Console.WriteLine(ConvertToKelvin(convertFrom, numToConvert).ToString("N1"));

//Kelvin to Celsius is C = K - 273.15
static double ConvertToCelsius(string fromIdentifier, double numToConvert)
{
    double result = 0;

    if (fromIdentifier == "1") return numToConvert;

    if (fromIdentifier == "2")
        result = (numToConvert - 32) * 0.5556;

    if (fromIdentifier == "3")
        result = numToConvert - 273.15;

    return result;
}
static double ConvertToFahrenheit(string fromIdentifier, double numToConvert)
{
    double result = 0;

    if (fromIdentifier == "1")
        result = numToConvert * 1.8 + 32;

    if (fromIdentifier == "2")
        return numToConvert;

    if (fromIdentifier == "3")
    {
        result = ConvertToCelsius("3", numToConvert);
        result = ConvertToFahrenheit("1", result);
    }

    return result;
}
static double ConvertToKelvin(string fromIdentifier, double numToConvert)
{
    double result = 0;

    if (fromIdentifier == "1")
        result = numToConvert + 273.15;

    if (fromIdentifier == "2")
    {
        result = ConvertToCelsius("2", numToConvert);
        result = ConvertToKelvin("1", result);
    }

    if (fromIdentifier == "3")
        result = numToConvert;

    return result;
}


