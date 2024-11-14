//Läs in användarens namn och ålder
Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine().ToLower();
Console.WriteLine("Hur gammal är du? Svara i hela antal år");
int ålder = int.Parse(Console.ReadLine());

//Kontrollera användarens grupp och skriva ut lämpligt meddelande

//namnsdag
if (namn == "felicia" || namn =="felix")
{
    Console.WriteLine("Du har namnsdag idag, du får gå ombord först!");
} //äldre än 75år
else if (ålder > 75)
{
    Console.WriteLine("Du får gå ombord i grupp 2, du är äldre än 75 år.");
} //mellan 18 och t.o.m 25
else if (ålder >=18 && ålder <=25)
{
    Console.WriteLine("Du får gå ombord i grupp 3, du är mellan 18 och 25 år.");
}
else
{
    Console.WriteLine("Du är välkommen ombord i grupp 4.");
}
