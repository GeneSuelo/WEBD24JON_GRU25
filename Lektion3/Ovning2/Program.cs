//Input  - ålder och inkomst
Console.WriteLine("Hur gammal är du? Svara i år.");
int ålder = int.Parse(Console.ReadLine());

Console.WriteLine("Hur mycket tjänar du i månaden? Svara i kronor.");
int inkomst = int.Parse(Console.ReadLine());

//Logik

if (ålder == 39)
{
    Console.WriteLine("Du är lika gammal som medelpersonen i Göteborg");
} else if (ålder > 39)
{
    Console.WriteLine("Du är äldre än medelpersonen i Göteborg");
} else
{
    Console.WriteLine("Du är yngre än medelpersonen i Göteborg");
}

if (inkomst == 36100)
{
    Console.WriteLine("Du tjänar lika mycket som medellönen är i Svergie");
} else if (inkomst > 36100)
{
    Console.WriteLine("Du tjänar mer än medellönen i Sverige");
} else
{
    Console.WriteLine("Du tjänar mindre än medellönen i Sverige");
}