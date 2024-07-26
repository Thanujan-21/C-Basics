using System;

class Entrypoint
{
    static void Main()
    {
        Console.WriteLine("What is your Name: ");
        String firstName = Console.ReadLine();
        
        Console.WriteLine("What is your Age: ");
        int age = int.ParseConsole.ReadLine();

        Console.WriteLine(firstName);

        Console.WriteLine(age);
    }
}
