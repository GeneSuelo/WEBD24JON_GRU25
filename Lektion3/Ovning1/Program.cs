//input
Console.WriteLine("Vilket land vann fotbolls-VM för damer år 2015");
string svar = Console.ReadLine().ToUpper();

//villkor (om svaret är USA/usa/Usa ?)
if (svar == "USA")
{
    Console.WriteLine("Rätt svar!");
} 
else
{
    Console.WriteLine("Fel svar!");
}

//if (svar != "usa")
//{
//    Console.WriteLine("Fel svar!");
//}