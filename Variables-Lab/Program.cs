namespace Variables_Lab;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int age = 28;

        Console.WriteLine("I am "+age+" years old");

        Console.WriteLine("Please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Now your last name: ");
        string lastName = Console.ReadLine();
        //Console.WriteLine("Hello, "+firstName+" "+lastName+"!");
        string fullName = firstName + " " + lastName;
        Console.WriteLine("My first name is "+firstName+" and my last name is "+lastName+", which means my full name is "+fullName+".");


        int fer = 100;
        double cel = (double)(fer - 32) * 5 / 9;
        Console.WriteLine("Celsius temperature: "+cel+" degrees celsius.");
    }
}

