
UserManager userManager = new UserManager();

// Lägga till användare
User user1 = new User("Alice", 30);
User user2 = new User("Bob", 25);
userManager.AddUser(user1);
userManager.AddUser(user2);

// Lägga till flera användare på en angiven position
List<User> newUsers = new List<User>
        {
            new User("Charlie", 35),
            new User("David", 40)
        };
userManager.InsertUsers(1, newUsers);

// Ta bort en användare
userManager.RemoveUser("Alice");

// Hämta antal användare
Console.WriteLine("Antal användare: " + userManager.GetUserCount());

// Visa användare
userManager.DisplayUsers();

// Rensa användarlistan
userManager.ClearUsers();

Console.WriteLine("\nAnvändarlistan har rensats.");
Console.WriteLine("Antal användare efter rensning: " + userManager.GetUserCount());


class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

class UserManager
{
    private List<User> users;

    public UserManager()
    {
        users = new List<User>();
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void InsertUsers(int index, List<User> newUsers)
    {
        users.InsertRange(index, newUsers);
    }

    public void RemoveUser(string name)
    {
        User userToRemove = null;

        foreach (var user in users)
        {
            if (user.Name == name)
            {
                userToRemove = user;
                break;
            }
        }

        if (userToRemove != null)
        {
            users.Remove(userToRemove);
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }


    public int GetUserCount()
    {
        return users.Count;
    }

    public void ClearUsers()
    {
        users.Clear();
    }

    public void DisplayUsers()
    {
        Console.WriteLine("Users:");
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }
}


