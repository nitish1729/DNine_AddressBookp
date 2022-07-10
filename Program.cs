
public class Wellcome
{
    public Wellcome()
    {
        Console.WriteLine("Welcome to Address Book");
    }
    public void display()
    {
        Console.WriteLine("Welcome to Address Book");
    }
    public static void display1(string well)
    {

        Console.WriteLine(well);
    }
    public static void Main()
    {
        Wellcome show = new Wellcome();
        show.display();
        display1("Welcome to Address Book");
    }
}


