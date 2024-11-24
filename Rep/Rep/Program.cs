using static System.Console;
//Skapa en metod som beräknar och returnerar det genomsnittliga värdet 
//av en array av heltal.

//Användning

int[] numbers = { 5, 15, 15, 20, 25 };
double average = CalcAverage(numbers);

int[] numbers2 = { 2, 10, 30, 20, 25 };
double average2 = CalcAverage(numbers2);

//Metoden ska ha följande signatur/deklaration
double CalcAverage(int[] num)
{
    if (num == null || num.Length == 0) //Om arrayen är tom ska metoden returnera 0
    {
        return 0;
    }

    double sum = 0;

    //Loopa genom arrayen och summera alla värden
    foreach (int numer in num)
    {
        sum +=numer;
    }

    //Dela summan med antalet värden i arrayen för att få genomsnittet
    double avr = sum / num.Length;
    return avr;
}

WriteLine($"Genomsnittet är: {average}");

WriteLine($"Genomsnittet är: {average2}");


