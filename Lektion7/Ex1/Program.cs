//Skapar lista genom att instansiera klassen List<t>
List<int> my_list = new List<int>();

// Lägger till element i listan genom att använda Add-metoden
my_list.Add(496);
my_list.Add(100);
my_list.Add(10);
my_list.Add(10000);
my_list.Add(1000);
my_list.Add(100000);
my_list.Add(1000);
my_list.Add(0000);

//Console.WriteLine(my_list); det går inte att skriva ut en lista på detta sätt

Console.WriteLine("unsorted list:");
PrintList(my_list); //Skriver ut listan

//Sorterar listan
my_list.Sort();
Console.WriteLine("sorted list:");
PrintList(my_list); //Skriver ut listan


//Använd Reverse för att vända på listan
my_list.Reverse();
Console.WriteLine("Reversed list:");
PrintList(my_list); //Skriver ut listan

//Skriver ut antalet element i listan
Console.WriteLine("Antal element i listan: " + my_list.Count);

//Radera ett element i listan
my_list.Remove(10);
Console.WriteLine("Antal element i listan efter radering: " + my_list.Count);
PrintList(my_list);

//Använd RemovaAt för att radera ett element på en specifik position
my_list.RemoveAt(2);
Console.WriteLine("Antal element i listan efter radering (RemoveAt): " + my_list.Count);
PrintList(my_list);

//Använd Clear för att radera alla element i listan
my_list.Clear();
Console.WriteLine("Antal element i listan efter radering (Clear): " + my_list.Count);

//Skapar en metod som skriver ut listan
void PrintList(List<int> list)
{
    foreach (int i in list)
    {
        Console.WriteLine(i);
    }
}