string namn = "Project1";
Project project = new Project(namn);

string namn2 = "Project2";
Project project2 = new Project(namn2);

// Skapa class Project med konstruktor som skriver ut "Project created"
class Project
{
    public string Name;
    public Project(string name)
    {
        //När projektet skapas skrivs detta ut
        Console.WriteLine($"Project {name} created");
    }
}



