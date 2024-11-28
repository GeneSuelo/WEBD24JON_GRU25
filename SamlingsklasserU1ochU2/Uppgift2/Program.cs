Dictionary<string, int> studentScores = new Dictionary<string, int>();

// Lägg till några studenter och deras poäng
AddStudent("Alice", 85);
AddStudent("Bob", 90);
AddStudent("Charlie", 78);

// Uppdatera poäng för en student
UpdatePoints("Bob", 95);

// Ta bort en student
RemoveStudent("Alice");

// Visa alla studenter och deras poäng
DisplayStudents();

void AddStudent(string name, int points)
{
    studentScores[name] = points;
}

void UpdatePoints(string name, int newPoints)
{
    if (studentScores.ContainsKey(name))
    {
        studentScores[name] = newPoints;
    }
    else
    {
        Console.WriteLine($"Student {name} finns inte i listan.");
    }
}

void RemoveStudent(string name)
{
    if (studentScores.ContainsKey(name))
    {
        studentScores.Remove(name);
    }
    else
    {
        Console.WriteLine($"Student {name} finns inte i listan.");
    }
}

void DisplayStudents()
{
    Console.WriteLine("Studenter och deras poäng:");
    foreach (var student in studentScores)
    {
        Console.WriteLine($"{student.Key}: {student.Value}");
    }
}