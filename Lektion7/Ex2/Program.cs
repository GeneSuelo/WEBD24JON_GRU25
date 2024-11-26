//Skapar dictionary - collection-initializer syntax
var cities = new Dictionary<string, string>()
{
    {"UK", "London, Manchester, Birmingham" },
    {"USA", "Chicago, New York, Washington" },
    {"India", "Mumbai,New Delhi, Pune" },
    {"Sweden", "Stockholm, Gothenburg, Malmo" }
};

//Skriver ut alla ellements
foreach (var city in cities)
{
    Console.WriteLine($"Key: {city.Key}, Value: {city.Value}");
}
Console.Clear();

Console.WriteLine(cities["UK"]); //Skriver ut London, Manchester, Birmingham

//använd ContainsKey("nyckel")
if (cities.ContainsKey("USA"))
{
    Console.WriteLine("USA finns i dictionary");
    Console.WriteLine(cities["USA"]);
}
else
{
    Console.WriteLine("USA finns inte i dictionary");
}

string result;
//använd TryGetValue("nyckel", out var)
if (cities.TryGetValue("Sweden", out result))
{
    Console.WriteLine("Din värde är:");
    Console.WriteLine(result);
}

//Använder ElementAt för att skriva 
for (int i = 0; i < cities.Count; i++)
{
    Console.WriteLine($"Key: {cities.ElementAt(i).Key}, Value: {cities.ElementAt(i).Value}");
}

Console.Clear();

//Uppdatera element
cities["UK"] = "Liverpool, Manchester, Birmingham";
cities["USA"] = "Chicago, New York, Washington, Los Angeles";
cities["France"] = "Paris, Marseille, Lyon"; 

if (cities.ContainsKey("France"))
{
    Console.WriteLine("France finns i dictionary");
    Console.WriteLine(cities["France"]);
}
else
{
    Console.WriteLine("France finns inte i dictionary");
}

//Ta bort element
cities.Remove("France");
cities.Remove("Serbien"); //Finns inte i dictionary men kastar inte exception

if (cities.ContainsKey("France"))
{
    Console.WriteLine("France finns i dictionary");
    Console.WriteLine(cities["France"]);
}
else
{
    Console.WriteLine("France finns inte i dictionary");
}

Console.Clear();

foreach (var city in cities)
{
    Console.WriteLine($"Key: {city.Key}, Value: {city.Value}");
}

Console.Clear();

cities.Clear(); //Raderar alla element i dictionary

foreach (var city in cities)
{
    Console.WriteLine($"Key: {city.Key}, Value: {city.Value}");
}

