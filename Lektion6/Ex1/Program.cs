//Object instansiering
Wellcome objwelcome = new Wellcome();

Wellcome objwelcome2 = new Wellcome();

//Method call
objwelcome.WelcomeMessage();

objwelcome2.WelcomeMessage();

//Klass definition
class Wellcome
{
    public void WelcomeMessage()
    {
        Console.WriteLine("Wellcome to OOP");
    }
}