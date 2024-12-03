﻿using InloggSystem;
using System.Data.Entity.Migrations.Model;

Console.WriteLine("Välkommen till inloggningssidan!");

while (true)
{
    Console.WriteLine("Välj en åtgärd:");
    Console.WriteLine("1. Sign in");
    Console.WriteLine("2. Log in");
    Console.WriteLine("3. Avsluta");
    
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Sign in");
            Console.Write("Ange ett användarnamn: ");
            string newUsername = Console.ReadLine();

            Console.Write("Ange ett lösenord: ");
            string newPassword = Console.ReadLine();

            // Skapa ett nytt User-objekt och lägga till i databasen
            AddUser(newUsername, newPassword);

            Console.WriteLine("Du har skapat ett konto. Gå tillbaka till huvudmeny för att logga in");
            break;
        case "2":
            Console.WriteLine("Log in");
            Console.Write("Ange ditt användarnamn: ");
            string username = Console.ReadLine();

            Console.Write("Ange ditt lösenord: ");
            string password = Console.ReadLine();

            // Hämta användaren från databasen om den finns
            //och jämför lösenordet
            var user = GetUser(username);
            if (user != null && user.Password == password)
            {
                Console.WriteLine("Du är inloggad!");
            }
            else
            {
                Console.WriteLine("Fel användarnamn eller lösenord.");
            }

            break;
        case "3":
            Console.WriteLine("Avslutar programmet...");
            return;
        default:
            Console.WriteLine("Felaktigt val, försök igen.");
            break;
    }
}

void AddUser(string username, string password)
{
    using (var context = new UserContext())
    {
        var user = new User
        {
            Username = username,
            Password = password
        };

        context.Users.Add(user);
        context.SaveChanges();

    }
}

User GetUser(string username)
{ 
    using (var context = new UserContext())
    {
        return context.Users.FirstOrDefault(u => u.Username == username);
    }
}