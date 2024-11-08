//Förklara för användare vad ska skrias in
Console.WriteLine("Skriv in en mening med tre ord, " +
    "avsluta med punkt.");
//Läs in användarens input
string mening = Console.ReadLine(); //Programmering är roligt.
//Byta plats 
int förstaMIndex = mening.IndexOf(" ");
int andraMIndex = mening.IndexOf(" ", förstaMIndex + 1);
int punktMIndex = mening.IndexOf(".");

string ord1 = mening[..förstaMIndex];
string ord2 = mening[(förstaMIndex + 1)..andraMIndex];
string ord3 = mening[(andraMIndex + 1)..punktMIndex];
//Skriva ut

Console.WriteLine($"{ord3} {ord2} {ord1}.");