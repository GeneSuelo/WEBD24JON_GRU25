//Input
Console.WriteLine("Ange rektangelns bredd: ");
float bredd = float.Parse(Console.ReadLine());

Console.WriteLine("Ange rektangelns höjd: ");
float höjd = float.Parse(Console.ReadLine());
//Beräkna arean
float area = (bredd * höjd) / 2;
//Skriv ut resultatet
Console.WriteLine($"Triangelns area är: {area} kvadratmeter");