using System;
class Program
{
    static void Main(string[] args)
    {
        // Let me ask for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        //Let me Ask for last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        //Let me Display result
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}