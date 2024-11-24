using System.Collections.ObjectModel;
//2. Skapa Collection av string typen och
//kopiera den till one dimensional Array.
//Skriva ut ellements i Arrayen. 

//Skapa Collection av string typen
Collection<string> myColl = new Collection<string>();

//Lägg till element i samlingen
myColl.Add("A");
myColl.Add("B");
myColl.Add("C");
myColl.Add("D");
myColl.Add("E");


//Skriv ut alla element i samlingen
foreach (string item in myColl)
{
    Console.WriteLine(item);
}

Console.WriteLine("________________________________");

//Ta bort element från samlingen
//myColl.Remove("E");

//Skapa ett string array
string[] myArr = new string[myColl.Count];

//Kopiera Collection till Array

myColl.CopyTo(myArr, 0);

//Ta bort element från samlingen
myColl.Remove("E");


//Skriv ut alla element i Arrayen
foreach (string item in myArr)
{
    Console.WriteLine(item);
}


//Skriv ut alla element i samlingen igen efter radering
foreach (string item in myColl)
{
    Console.WriteLine(item);
}
