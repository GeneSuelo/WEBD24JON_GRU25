int sum = 0, factorial = 1;

//input
Console.WriteLine("Ange numret som summeras och beräknas faktoriel till: ");
int n = int.Parse(Console.ReadLine());


//beräkna summan och factorialen
for (int i = 1; i <= n; i++)
{
    sum += i; // sum = sum + i; 
    factorial *= i; // factorial = factorial * i;
}

//Skriva ut värdet av summan och factorialen    
Console.WriteLine($"Summan av talen från a till {n}: {sum}");
Console.WriteLine($"{n}!: {factorial}");