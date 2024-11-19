using static System.Array;
using static System.Console;
//Övning 1
string[] lands = new string[] 
            {
                "Serbien",
                "Kroatien",
                "Grekland",
                "Sverige",
                "USA",
                "Nederländerna"
            };
WriteLine("Innan sort: ");
Utskrift(lands);
WriteLine();

Sort(lands);
WriteLine("Efter sort: ");
Utskrift(lands);
WriteLine();

Clear();

//Övning 2

int[] tals = { 5, 3, 8, 2, 7, 1, 4, 6 };
WriteLine("Innan sort: ");
UtskriftNum(tals);
WriteLine();

Sort(tals);

WriteLine("Efter sort:");
UtskriftNum(tals);
WriteLine();

Reverse(tals);

WriteLine("Efter reverse: ");
UtskriftNum(tals);
Clear();

WriteLine("____________________________________");
//Övning 3
Countdown(10);
Clear();
Countdown(50);

void Countdown(int number)
{
    if (number == 0) return; //basfall
 
    WriteLine(number);
    Countdown(number - 1);
}

void Utskrift(string[] array)
{
    foreach (string e in array)
    {
        WriteLine(e);
    }
}

void UtskriftNum(int[] array)
{
    foreach (int e in array)
    {
        WriteLine(e);
    }
}