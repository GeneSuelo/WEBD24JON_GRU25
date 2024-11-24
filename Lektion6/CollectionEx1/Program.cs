using System.Collections.ObjectModel;

//Skapa samling av heltal med Collection<T>
//Instansiera/skapa en samling av heltal
Collection<int> myColl = new Collection<int>();

//Lägg till element i samlingen
myColl.Add(1);
myColl.Add(2);
myColl.Add(3);
myColl.Add(4);
myColl.Add(5);
myColl.Add(35);

//Skriv ut alla element i samlingen
foreach (int i in myColl)
{
    Console.WriteLine(i);
}