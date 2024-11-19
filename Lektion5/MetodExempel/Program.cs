Console.WriteLine("Till vilket tal vill du räkna med?");
int valdaTal = ReadNumber();
Count(valdaTal);


void Count(int numberToCountTo)
{
    for (int i = 1; i <= numberToCountTo; i++)
        Console.WriteLine(i);
}

int ReadNumber()
{
    string input = Console.ReadLine();
    int number = int.Parse(input);
    return number;
}
//Method overloading
//Console.WriteLine("Programmet avslutas.");
//Console.WriteLine(true);
//Console.WriteLine(100);