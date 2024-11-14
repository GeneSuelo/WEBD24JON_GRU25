//input
Console.WriteLine("Skriv in rektangelns bredd: ");
int bredd = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv in rektangelns höjd: ");
int höjd = int.Parse(Console.ReadLine());
Console.WriteLine();
//bygga rektangeln
for (int i = 0; i < höjd; i++)
{ 
    for (int j = 0; j < bredd; j++)
    {   //Om man är på första eller sista raden eller kolumnen så skrivs ett X annars ett " "
        if (i==0 || j ==0 || i == höjd - 1 || j == bredd - 1) //Skriv kod i villkoret
            Console.Write("X");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}