//Förklaring + meny
Console.WriteLine("Detta är omvandlingsprogram");
string val = "";
while (val !="3")
{
    Console.WriteLine();
    Console.WriteLine("Välj ett av följande alternativ");
    Console.WriteLine("1. Omvandla meter till kilometer");
    Console.WriteLine("2. Omvandla kilometer till meter");
    Console.WriteLine("3. Avsluta programmet");
    Console.WriteLine("_______________________________");

    val = Console.ReadLine();

    //Logik bakom meny
    switch (val)
    {
        case "1":
            Console.WriteLine("Skriv in längden i meter");
            double meter = double.Parse(Console.ReadLine());
            Console.WriteLine($"Längden du skrev in är detsamma som {meter/1000} kilometer");
            break;
        case "2":
            Console.WriteLine("Skriv in längden i kilometer");
            double kilometer = double.Parse(Console.ReadLine());
            Console.WriteLine($"Längden du skrev in är detsamma som {kilometer*1000} meter");
            break;
        case "3":
            Console.WriteLine("Programmet avslutas...");
            break;
        default:
            Console.WriteLine("Felaktigt val, försök igen");
            break;
    }
}

